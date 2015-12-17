/*
 * Copyright (C) 2015 Colin Mackie.
 * This software is distributed under the terms of the GNU General Public License.
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
// Decompiled with JetBrains decompiler
// Type: WinAuth.ShowSteamTradesForm
// Assembly: WinAuth, Version=3.3.7.2, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using WinAuth.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WinAuth
{
  public partial class ShowSteamTradesForm : Form
  {
    private void ShowSteamTradesForm_Load(object sender, EventArgs e)
    {
      for (int index = 0; index < this.tabs.TabPages.Count; ++index)
        this.m_tabPages.Add(this.tabs.TabPages[index].Name, this.tabs.TabPages[index]);
      this.tabs.TabPages.RemoveByKey("tradesTab");
      this.tabs.SelectedTab = this.tabs.TabPages[0];
    }

    private void ShowSteamTradesForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.DialogResult = DialogResult.OK;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }

    private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
    {
      TabPage tabPage = this.tabs.TabPages[e.Index];
      e.Graphics.FillRectangle((Brush) new SolidBrush(tabPage.BackColor), e.Bounds);
      Rectangle bounds = e.Bounds;
      int y = e.State == DrawItemState.Selected ? -2 : 1;
      bounds.Offset(1, y);
      TextRenderer.DrawText((IDeviceContext) e.Graphics, tabPage.Text, this.Font, bounds, tabPage.ForeColor);
      this.captchaGroup.BackColor = tabPage.BackColor;
    }

    private void captchaButton_Click(object sender, EventArgs e)
    {
      if (this.captchacodeField.Text.Trim().Length == 0)
      {
        int num = (int) WinAuthForm.ErrorDialog((Form) this, "Please enter the characters in the image", (Exception) null, MessageBoxButtons.OK);
      }
      else
      {
        this.m_state.Username = this.usernameField.Text.Trim();
        this.m_state.Password = this.passwordField.Text.Trim();
        this.m_state.CaptchaText = this.captchacodeField.Text.Trim();
        this.Process();
      }
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
      if (this.usernameField.Text.Trim().Length == 0 || this.passwordField.Text.Trim().Length == 0)
      {
        int num = (int) WinAuthForm.ErrorDialog((Form) this, "Please enter your username and password", (Exception) null, MessageBoxButtons.OK);
      }
      else
      {
        this.m_state.Username = this.usernameField.Text.Trim();
        this.m_state.Password = this.passwordField.Text.Trim();
        this.Process();
      }
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void ShowSteamTradesForm_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar == 13)
      {
        string name = this.tabs.SelectedTab.Name;
        if (!(name == "loginTab"))
        {
          if (name == "tradesTab")
            e.Handled = true;
          else
            e.Handled = false;
        }
        else
        {
          e.Handled = true;
          JObject.Parse(this.Authenticator.SteamData);
          this.m_state.AuthCode = this.Authenticator.CurrentCode;
          if (this.m_state.RequiresCaptcha)
            this.captchaButton_Click(sender, new EventArgs());
          else
            this.loginButton_Click(sender, new EventArgs());
        }
      }
      else
        e.Handled = false;
    }

    private void Process()
    {
label_0:
      try
      {
        Cursor current = Cursor.Current;
        Cursor.Current = Cursors.WaitCursor;
        Application.DoEvents();
        string str = this.Authenticator.LoadTrades((SteamAuthenticator.SteamSession) this.m_state);
        Cursor.Current = current;
        if (str == null)
        {
          if (this.m_state.Error == "Incorrect Login")
          {
            int num1 = (int) WinAuthForm.ErrorDialog((Form) this, "Invalid username or password", (Exception) null, MessageBoxButtons.OK);
          }
          else if (this.m_state.Requires2FA)
          {
            int num2 = (int) WinAuthForm.ErrorDialog((Form) this, "Invalid authenticator code: are you sure this is the current authenticator for your account?", (Exception) null, MessageBoxButtons.OK);
          }
          else
          {
            if (!string.IsNullOrEmpty(this.m_state.Error))
            {
              int num3 = (int) WinAuthForm.ErrorDialog((Form) this, this.m_state.Error, (Exception) null, MessageBoxButtons.OK);
            }
            if (this.m_state.RequiresCaptcha)
            {
              using (WebClient webClient = new WebClient())
              {
                using (MemoryStream memoryStream = new MemoryStream(webClient.DownloadData(this.m_state.CaptchaUrl)))
                  this.captchaBox.Image = Image.FromStream((Stream) memoryStream);
              }
              this.loginButton.Enabled = false;
              this.captchaGroup.Visible = true;
              this.captchacodeField.Text = "";
              this.captchacodeField.Focus();
            }
            else
            {
              this.loginButton.Enabled = true;
              this.captchaGroup.Visible = false;
              if (this.tabs.TabPages.ContainsKey("authTab"))
                this.tabs.TabPages.RemoveByKey("authTab");
              if (this.m_state.RequiresLogin)
              {
                this.ShowTab("loginTab", true);
                this.usernameField.Focus();
              }
              else
              {
                string message = this.m_state.Error;
                if (string.IsNullOrEmpty(message))
                  message = "Unable to load trades for your account. Please try again later.";
                int num4 = (int) WinAuthForm.ErrorDialog((Form) this, message, (Exception) null, MessageBoxButtons.OK);
              }
            }
          }
        }
        else
        {
          this.m_state.Trades = new List<ShowSteamTradesForm.Trade>();
          Regex regex1 = new Regex("\"mobileconf_list_entry\"(.*?)>(.*?)\"mobileconf_list_entry_sep\"", RegexOptions.IgnoreCase | RegexOptions.Singleline);
          Regex regex2 = new Regex("\\sid\\s*=\\s*\"([^\"]+)\"", RegexOptions.IgnoreCase | RegexOptions.Singleline);
          Regex regex3 = new Regex("data-confid\\s*=\\s*\"([^\"]+)\"", RegexOptions.IgnoreCase | RegexOptions.Singleline);
          Regex regex4 = new Regex("data-key\\s*=\\s*\"([^\"]+)\"", RegexOptions.IgnoreCase | RegexOptions.Singleline);
          Regex regex5 = new Regex("\"mobileconf_list_entry_icon\"(.*?)src=\"([^\"]+)\"", RegexOptions.IgnoreCase | RegexOptions.Singleline);
          Regex regex6 = new Regex("\"mobileconf_list_entry_description\".*?<div>([^<]*)</div>\\s*<div>([^<]*)</div>\\s*<div>([^<]*)</div>\\s*</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
          string input1 = str;
          for (Match match1 = regex1.Match(input1); match1.Success; match1 = match1.NextMatch())
          {
            string input2 = match1.Groups[1].Value;
            ShowSteamTradesForm.Trade trade = new ShowSteamTradesForm.Trade();
            Match match2 = regex2.Match(input2);
            if (match2.Success)
              trade.Id = match2.Groups[1].Value;
            Match match3 = regex3.Match(input2);
            if (match3.Success)
              trade.ConfigId = match3.Groups[1].Value;
            Match match4 = regex4.Match(input2);
            if (match4.Success)
              trade.Key = match4.Groups[1].Value;
            string input3 = match1.Groups[2].Value;
            Match match5 = regex5.Match(input3);
            if (match5.Success)
            {
              if (match5.Groups[1].Value.IndexOf("offline") != -1)
                trade.Offline = true;
              trade.Image = match5.Groups[2].Value;
            }
            Match match6 = regex6.Match(input3);
            if (match6.Success)
            {
              trade.Details = match6.Groups[1].Value;
              trade.Traded = match6.Groups[2].Value;
              trade.When = match6.Groups[3].Value;
            }
            this.m_state.Trades.Add(trade);
          }
          TabPage tabPage = this.ShowTab("tradesTab", true);
          tabPage.SuspendLayout();
          tabPage.Controls.Remove((Control) this.tradePanelMaster);
          for (int index = 0; index < this.m_state.Trades.Count; ++index)
          {
            ShowSteamTradesForm.Trade trade1 = this.m_state.Trades[index];
            Panel panel = this.Clone((Control) this.tradePanelMaster, "_" + trade1.Id) as Panel;
            panel.SuspendLayout();
            byte[] data = this.m_state.GetData(trade1.Image);
            if (data != null && data.Length != 0)
            {
              using (MemoryStream memoryStream = new MemoryStream(data))
                this.FindControl<PictureBox>((Control) panel, "tradeImage").Image = Image.FromStream((Stream) memoryStream);
            }
            this.FindControl<Label>((Control) panel, "tradeLabel").Text = trade1.Details + ". " + trade1.Traded + ". " + trade1.When;
            Button control1 = this.FindControl<Button>((Control) panel, "tradeAccept");
            ShowSteamTradesForm.Trade trade2 = trade1;
            control1.Tag = (object) trade2;
            EventHandler eventHandler1 = new EventHandler(this.tradeAccept_Click);
            control1.Click += eventHandler1;
            Button control2 = this.FindControl<Button>((Control) panel, "tradeReject");
            ShowSteamTradesForm.Trade trade3 = trade1;
            control2.Tag = (object) trade3;
            EventHandler eventHandler2 = new EventHandler(this.tradeReject_Click);
            control2.Click += eventHandler2;
            panel.Top = panel.Height * index;
            panel.ResumeLayout();
            tabPage.Controls.Add((Control) panel);
          }
          if (this.m_state.Trades.Count == 0)
            this.tradesEmptyLabel.Visible = true;
          tabPage.ResumeLayout();
          this.closeButton.Location = this.cancelButton.Location;
          this.closeButton.Visible = true;
          this.cancelButton.Visible = false;
        }
      }
      catch (InvalidEnrollResponseException ex)
      {
        if (WinAuthForm.ErrorDialog((Form) this, "An error occurred while loading trades", (Exception) ex, MessageBoxButtons.RetryCancel) == DialogResult.Retry)
          goto label_0;
      }
    }

    private void AcceptTrade(ShowSteamTradesForm.Trade trade)
    {
      try
      {
        string json = this.Authenticator.ConfirmTrade((SteamAuthenticator.SteamSession) this.m_state, trade.ConfigId, trade.Key, true);
        if (string.IsNullOrEmpty(json))
          throw new InvalidTradesResponseException("Blank response", (Exception) null);
        JToken jtoken = JObject.Parse(json).SelectToken("success");
        if (jtoken == null || !Extensions.Value<bool>((IEnumerable<JToken>) jtoken))
        {
          int num1 = (int) WinAuthForm.ErrorDialog((Form) this, "Trade cannot be rejected", (Exception) null, MessageBoxButtons.OK);
        }
        else
        {
          this.m_state.Trades.Remove(trade);
          this.FindControl<Button>((Control) this.tabs.SelectedTab, "tradeAccept_" + trade.Id).Visible = false;
          this.FindControl<Button>((Control) this.tabs.SelectedTab, "tradeReject_" + trade.Id).Visible = false;
          Label control = this.FindControl<Label>((Control) this.tabs.SelectedTab, "tradeStatus_" + trade.Id);
          string str = "Accepted";
          control.Text = str;
          int num2 = 1;
          control.Visible = num2 != 0;
        }
      }
      catch (InvalidTradesResponseException ex)
      {
        int num = (int) WinAuthForm.ErrorDialog((Form) this, "Error trying to accept trade", (Exception) ex, MessageBoxButtons.OK);
      }
    }

    private void RejectTrade(ShowSteamTradesForm.Trade trade)
    {
      try
      {
        string json = this.Authenticator.ConfirmTrade((SteamAuthenticator.SteamSession) this.m_state, trade.ConfigId, trade.Key, false);
        if (string.IsNullOrEmpty(json))
          throw new InvalidTradesResponseException("Blank response", (Exception) null);
        JToken jtoken = JObject.Parse(json).SelectToken("success");
        if (jtoken == null || !Extensions.Value<bool>((IEnumerable<JToken>) jtoken))
        {
          int num1 = (int) WinAuthForm.ErrorDialog((Form) this, "Trade cannot be rejected", (Exception) null, MessageBoxButtons.OK);
        }
        else
        {
          this.m_state.Trades.Remove(trade);
          this.FindControl<Button>((Control) this.tabs.SelectedTab, "tradeAccept_" + trade.Id).Visible = false;
          this.FindControl<Button>((Control) this.tabs.SelectedTab, "tradeReject_" + trade.Id).Visible = false;
          Label control = this.FindControl<Label>((Control) this.tabs.SelectedTab, "tradeStatus_" + trade.Id);
          string str = "Rejected";
          control.Text = str;
          int num2 = 1;
          control.Visible = num2 != 0;
        }
      }
      catch (InvalidTradesResponseException ex)
      {
        int num = (int) WinAuthForm.ErrorDialog((Form) this, "Error trying to reject trade", (Exception) ex, MessageBoxButtons.OK);
      }
    }


    private TabPage ShowTab(string name, bool only = true)
    {
      if (only)
        this.tabs.TabPages.Clear();
      if (!this.tabs.TabPages.ContainsKey(name))
        this.tabs.TabPages.Add(this.m_tabPages[name]);
      this.tabs.SelectedTab = this.tabs.TabPages[name];
      return this.tabs.SelectedTab;
    }

    private void tradeAccept_Click(object sender, EventArgs e)
    {
      this.AcceptTrade((sender as Button).Tag as ShowSteamTradesForm.Trade);
    }

    private void tradeReject_Click(object sender, EventArgs e)
    {
      this.RejectTrade((sender as Button).Tag as ShowSteamTradesForm.Trade);
    }


    private class Trade
    {
      public string Id;
      public string ConfigId;
      public string Key;
      public bool Offline;
      public string Image;
      public string Details;
      public string Traded;
      public string When;
    }

    private class TradeSession : SteamAuthenticator.SteamSession
    {
      public List<ShowSteamTradesForm.Trade> Trades { get; set; }
    }
  }
}

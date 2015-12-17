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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace WinAuth
{
	partial class ShowSteamTradesForm
	{
		private ShowSteamTradesForm.TradeSession m_state = new ShowSteamTradesForm.TradeSession();
		private Dictionary<string, TabPage> m_tabPages = new Dictionary<string, TabPage>();
		private Label loginTabLabel;
		private Button loginButton;
		private Label captchaTabLabel;
		private Button cancelButton;
		private TextBox captchacodeField;
		private TextBox usernameField;
		private Button captchaButton;
		private TabControl tabs;
		private TabPage loginTab;
		private Label passwordLabel;
		private Label usernameLabel;
		private TextBox passwordField;
		private TabPage tradesTab;
		private PictureBox captchaBox;
		private Panel captchaGroup;
		private Button closeButton;
		private Panel tradePanelMaster;
		private PictureBox tradeImage;
		private Button tradeReject;
		private Button tradeAccept;
		private Label tradeLabel;
		private PictureBox tradeSep;
		private Label tradeStatus;
		private Label tradesEmptyLabel;

		public SteamAuthenticator Authenticator { get; set; }

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.loginButton = new Button();
			this.loginTabLabel = new Label();
			this.captchaButton = new Button();
			this.captchacodeField = new TextBox();
			this.usernameField = new TextBox();
			this.captchaTabLabel = new Label();
			this.cancelButton = new Button();
			this.tabs = new TabControl();
			this.loginTab = new TabPage();
			this.captchaGroup = new Panel();
			this.captchaBox = new PictureBox();
			this.passwordField = new TextBox();
			this.passwordLabel = new Label();
			this.usernameLabel = new Label();
			this.tradesTab = new TabPage();
			this.tradePanelMaster = new Panel();
			this.tradeSep = new PictureBox();
			this.tradeLabel = new Label();
			this.tradeImage = new PictureBox();
			this.tradeReject = new Button();
			this.tradeAccept = new Button();
			this.tradeStatus = new Label();
			this.closeButton = new Button();
			this.tradesEmptyLabel = new Label();
			this.tabs.SuspendLayout();
			this.loginTab.SuspendLayout();
			this.captchaGroup.SuspendLayout();
			((ISupportInitialize) this.captchaBox).BeginInit();
			this.tradesTab.SuspendLayout();
			this.tradePanelMaster.SuspendLayout();
			((ISupportInitialize) this.tradeSep).BeginInit();
			((ISupportInitialize) this.tradeImage).BeginInit();
			this.SuspendLayout();
			this.loginButton.Location = new Point(104, (int) sbyte.MaxValue);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new Size(110, 24);
			this.loginButton.TabIndex = 2;
			this.loginButton.Text = "Login";
			this.loginButton.Click += new EventHandler(this.loginButton_Click);
			this.loginTabLabel.Location = new Point(7, 10);
			this.loginTabLabel.Name = "loginTabLabel";
			this.loginTabLabel.Size = new Size(431, 46);
			this.loginTabLabel.TabIndex = 0;
			this.loginTabLabel.Text = "Enter your steam username and password. This is needed to login to your account to add a new authenticator.";
			this.captchaButton.Location = new Point(97, 118);
			this.captchaButton.Name = "captchaButton";
			this.captchaButton.Size = new Size(110, 23);
			this.captchaButton.TabIndex = 1;
			this.captchaButton.Text = "Login";
			this.captchaButton.Click += new EventHandler(this.captchaButton_Click);
			this.captchacodeField.Location = new Point(97, 78);
			this.captchacodeField.MaxLength = (int) short.MaxValue;
			this.captchacodeField.Name = "captchacodeField";
			this.captchacodeField.PasswordChar = char.MinValue;
			this.captchacodeField.ScrollBars = ScrollBars.None;
			this.captchacodeField.SelectedText = "";
			this.captchacodeField.Size = new Size(206, 22);
			this.captchacodeField.TabIndex = 0;
			this.usernameField.Location = new Point(104, 59);
			this.usernameField.MaxLength = (int) short.MaxValue;
			this.usernameField.Name = "usernameField";
			this.usernameField.PasswordChar = char.MinValue;
			this.usernameField.ScrollBars = ScrollBars.None;
			this.usernameField.SelectedText = "";
			this.usernameField.Size = new Size(177, 22);
			this.usernameField.TabIndex = 0;
			this.captchaTabLabel.AutoSize = true;
			this.captchaTabLabel.Location = new Point(97, 10);
			this.captchaTabLabel.Name = "captchaTabLabel";
			this.captchaTabLabel.Size = new Size(249, 19);
			this.captchaTabLabel.TabIndex = 0;
			this.captchaTabLabel.Text = "Enter the characters you see in the image";
			this.cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.cancelButton.DialogResult = DialogResult.Cancel;
			this.cancelButton.Location = new Point(403, 518);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new Size(75, 23);
			this.cancelButton.TabIndex = 0;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new EventHandler(this.cancelButton_Click);
			this.tabs.Controls.Add((Control) this.loginTab);
			this.tabs.Controls.Add((Control) this.tradesTab);
			this.tabs.DrawMode = TabDrawMode.OwnerDrawFixed;
			this.tabs.ItemSize = new Size(120, 18);
			this.tabs.Location = new Point(15, 63);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 1;
			this.tabs.Size = new Size(464, 444);
			this.tabs.TabIndex = 0;
			this.tabs.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);
			this.loginTab.BackColor = SystemColors.Control;
			this.loginTab.Controls.Add((Control) this.captchaGroup);
			this.loginTab.Controls.Add((Control) this.loginButton);
			this.loginTab.Controls.Add((Control) this.passwordField);
			this.loginTab.Controls.Add((Control) this.usernameField);
			this.loginTab.Controls.Add((Control) this.passwordLabel);
			this.loginTab.Controls.Add((Control) this.usernameLabel);
			this.loginTab.Controls.Add((Control) this.loginTabLabel);
			this.loginTab.ForeColor = SystemColors.ControlText;
			this.loginTab.Location = new Point(4, 22);
			this.loginTab.Name = "loginTab";
			this.loginTab.Padding = new Padding(3);
			this.loginTab.Size = new Size(456, 418);
			this.loginTab.TabIndex = 0;
			this.loginTab.Tag = (object) "";
			this.loginTab.Text = "Login";
			this.captchaGroup.BackColor = SystemColors.ControlLightLight;
			this.captchaGroup.Controls.Add((Control) this.captchaBox);
			this.captchaGroup.Controls.Add((Control) this.captchaTabLabel);
			this.captchaGroup.Controls.Add((Control) this.captchacodeField);
			this.captchaGroup.Controls.Add((Control) this.captchaButton);
			this.captchaGroup.Location = new Point(7, 115);
			this.captchaGroup.Name = "captchaGroup";
			this.captchaGroup.Size = new Size(431, 167);
			this.captchaGroup.TabIndex = 4;
			this.captchaGroup.Visible = false;
			this.captchaBox.Location = new Point(97, 32);
			this.captchaBox.Name = "captchaBox";
			this.captchaBox.Size = new Size(206, 40);
			this.captchaBox.TabIndex = 3;
			this.captchaBox.TabStop = false;
			this.passwordField.Location = new Point(104, 87);
			this.passwordField.MaxLength = (int) short.MaxValue;
			this.passwordField.Name = "passwordField";
			this.passwordField.PasswordChar = '●';
			this.passwordField.ScrollBars = ScrollBars.None;
			this.passwordField.SelectedText = "";
			this.passwordField.Size = new Size(177, 22);
			this.passwordField.TabIndex = 1;
			this.passwordField.UseSystemPasswordChar = true;
			this.passwordLabel.Location = new Point(18, 87);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new Size(80, 25);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Password";
			this.usernameLabel.Location = new Point(18, 60);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new Size(80, 25);
			this.usernameLabel.TabIndex = 1;
			this.usernameLabel.Text = "Username";
			this.tradesTab.AutoScroll = true;
			this.tradesTab.Controls.Add((Control) this.tradePanelMaster);
			this.tradesTab.Controls.Add((Control) this.tradesEmptyLabel);
			this.tradesTab.Location = new Point(4, 22);
			this.tradesTab.Name = "tradesTab";
			this.tradesTab.Size = new Size(456, 418);
			this.tradesTab.TabIndex = 2;
			this.tradesTab.Tag = (object) "";
			this.tradesTab.Text = "Trades";
			this.tradePanelMaster.BackColor = SystemColors.ControlLightLight;
			this.tradePanelMaster.Controls.Add((Control) this.tradeSep);
			this.tradePanelMaster.Controls.Add((Control) this.tradeLabel);
			this.tradePanelMaster.Controls.Add((Control) this.tradeImage);
			this.tradePanelMaster.Controls.Add((Control) this.tradeReject);
			this.tradePanelMaster.Controls.Add((Control) this.tradeAccept);
			this.tradePanelMaster.Controls.Add((Control) this.tradeStatus);
			this.tradePanelMaster.Location = new Point(4, 3);
			this.tradePanelMaster.Name = "tradePanelMaster";
			this.tradePanelMaster.Size = new Size(449, 73);
			this.tradePanelMaster.TabIndex = 0;
			this.tradeSep.Image = (Image) WinAuth.Properties.Resources.BluePixel;
			this.tradeSep.ImeMode = ImeMode.NoControl;
			this.tradeSep.Location = new Point(0, 70);
			this.tradeSep.Name = "tradeSep";
			this.tradeSep.Size = new Size(448, 1);
			this.tradeSep.SizeMode = PictureBoxSizeMode.StretchImage;
			this.tradeSep.TabIndex = 6;
			this.tradeSep.TabStop = false;
			this.tradeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.tradeLabel.Location = new Point(46, 10);
			this.tradeLabel.Name = "tradeLabel";
			this.tradeLabel.Size = new Size(283, 50);
			this.tradeLabel.TabIndex = 4;
			this.tradeLabel.Text = "Label1";
			this.tradeImage.Location = new Point(4, 12);
			this.tradeImage.Name = "tradeImage";
			this.tradeImage.Size = new Size(36, 36);
			this.tradeImage.TabIndex = 3;
			this.tradeImage.TabStop = false;
			this.tradeReject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.tradeReject.BackColor = SystemColors.Control;
			this.tradeReject.Location = new Point(357, 39);
			this.tradeReject.Name = "tradeReject";
			this.tradeReject.Size = new Size(75, 23);
			this.tradeReject.TabIndex = 1;
			this.tradeReject.Text = "Reject";
			this.tradeReject.Click += new EventHandler(this.tradeReject_Click);
			this.tradeAccept.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.tradeAccept.BackColor = SystemColors.Control;
			this.tradeAccept.Location = new Point(357, 10);
			this.tradeAccept.Name = "tradeAccept";
			this.tradeAccept.Size = new Size(75, 23);
			this.tradeAccept.TabIndex = 0;
			this.tradeAccept.Text = "Accept";
			this.tradeAccept.Click += new EventHandler(this.tradeAccept_Click);
			this.tradeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.tradeStatus.Location = new Point(335, 8);
			this.tradeStatus.Name = "tradeStatus";
			this.tradeStatus.Size = new Size(97, 28);
			this.tradeStatus.TabIndex = 4;
			this.tradeStatus.Text = "tradeStatus";
			this.tradeStatus.TextAlign = ContentAlignment.TopRight;
			this.tradeStatus.Visible = false;
			this.closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.closeButton.DialogResult = DialogResult.OK;
			this.closeButton.Location = new Point(324, 518);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new Size(75, 23);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "Close";
			this.closeButton.Visible = false;
			this.closeButton.Click += new EventHandler(this.closeButton_Click);
			this.tradesEmptyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.tradesEmptyLabel.Location = new Point(4, 4);
			this.tradesEmptyLabel.Name = "tradesEmptyLabel";
			this.tradesEmptyLabel.Size = new Size(448, 29);
			this.tradesEmptyLabel.TabIndex = 4;
			this.tradesEmptyLabel.Text = "You have no trades";
			this.tradesEmptyLabel.Visible = false;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = (IButtonControl) this.cancelButton;
			this.ClientSize = new Size(501, 564);
			this.Controls.Add((Control) this.tabs);
			this.Controls.Add((Control) this.closeButton);
			this.Controls.Add((Control) this.cancelButton);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "ShowSteamTradesForm";
			this.ShowIcon = false;
			this.Text = "Steam Trades";
			this.FormClosing += new FormClosingEventHandler(this.ShowSteamTradesForm_FormClosing);
			this.Load += new EventHandler(this.ShowSteamTradesForm_Load);
			this.KeyPress += new KeyPressEventHandler(this.ShowSteamTradesForm_KeyPress);
			this.tabs.ResumeLayout(false);
			this.loginTab.ResumeLayout(false);
			this.captchaGroup.ResumeLayout(false);
			this.captchaGroup.PerformLayout();
			((ISupportInitialize) this.captchaBox).EndInit();
			this.tradesTab.ResumeLayout(false);
			this.tradePanelMaster.ResumeLayout(false);
			((ISupportInitialize) this.tradeSep).EndInit();
			((ISupportInitialize) this.tradeImage).EndInit();
			this.ResumeLayout(false);
		}

		public ShowSteamTradesForm()
		{
			this.InitializeComponent();
		}

		private T FindControl<T>(Control control, string name) where T : Control
		{
			if (control.Name.StartsWith(name) && control is T)
				return (T) control;
			foreach (Control control1 in (ArrangedElementCollection) control.Controls)
			{
				T control2 = this.FindControl<T>(control1, name);
				if ((object) control2 != null)
					return control2;
			}
			return default (T);
		}

		private Control Clone(Control control, string suffix)
		{
			Type type = control.GetType();
			Control control1 = Activator.CreateInstance(type) as Control;
			control1.Name = control.Name + (!string.IsNullOrEmpty(suffix) ? suffix : string.Empty);
			control1.SuspendLayout();
			if (control1 is ISupportInitialize)
				((ISupportInitialize) control1).BeginInit();
			int num = 84;
			foreach (PropertyInfo propertyInfo in type.GetProperties((BindingFlags) num))
			{
				if (propertyInfo.CanWrite && propertyInfo.CanRead && (!(propertyInfo.Name == "Controls") && !(propertyInfo.Name == "Name")) && !(propertyInfo.Name == "WindowTarget"))
				{
					object obj1 = propertyInfo.GetValue((object) control);
					if (obj1 != null && !obj1.GetType().IsValueType)
					{
						if (obj1 is ICloneable)
							obj1 = ((ICloneable) obj1).Clone();
						else if (obj1 is ISerializable)
						{
							object obj2 = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(obj1));
							if (obj2.GetType() == obj1.GetType())
								obj1 = obj2;
						}
					}
					propertyInfo.SetValue((object) control1, obj1);
				}
			}
			if (control.Controls != null)
			{
				foreach (Control control2 in (ArrangedElementCollection) control.Controls)
					control1.Controls.Add(this.Clone(control2, suffix));
			}
			control1.ResumeLayout();
			if (control1 is ISupportInitialize)
				((ISupportInitialize) control1).EndInit();
			return control1;
		}
		#endregion
	}
}

﻿namespace WinAuth
{
			
	partial class WinAuthForm
  {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinAuthForm));
			this.mainTimer = new System.Windows.Forms.Timer(this.components);
			this.authenticatorMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addAuthenticatorMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.optionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.passwordTimer = new System.Windows.Forms.Timer(this.components);
			this.hotkeyTimer = new System.Windows.Forms.Timer(this.components);
			this.yubiPanel = new System.Windows.Forms.Panel();
			this.yubiRetryButton = new System.Windows.Forms.Button();
			this.yubiLabel = new System.Windows.Forms.Label();
			this.yubiImage = new System.Windows.Forms.PictureBox();
			this.passwordPanel = new System.Windows.Forms.Panel();
			this.passwordButton = new System.Windows.Forms.Button();
			this.passwordErrorLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordField = new System.Windows.Forms.TextBox();
			this.introLabel = new System.Windows.Forms.Label();
			this.commandPanel = new System.Windows.Forms.Panel();
			this.newVersionLink = new System.Windows.Forms.LinkLabel();
			this.optionsButton = new System.Windows.Forms.Button();
			this.addAuthenticatorButton = new System.Windows.Forms.Button();
			this.authenticatorList = new WinAuth.AuthenticatorListBox();
			this.loadingPanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.authenticatorMenu.SuspendLayout();
			this.yubiPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.yubiImage)).BeginInit();
			this.passwordPanel.SuspendLayout();
			this.commandPanel.SuspendLayout();
			this.loadingPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainTimer
			// 
			this.mainTimer.Enabled = true;
			this.mainTimer.Interval = 500;
			this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
			// 
			// authenticatorMenu
			// 
			this.authenticatorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
			this.authenticatorMenu.Name = "authenticatorMenu";
			this.authenticatorMenu.Size = new System.Drawing.Size(97, 26);
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.testToolStripMenuItem.Text = "Test";
			// 
			// addAuthenticatorMenu
			// 
			this.addAuthenticatorMenu.Name = "addMenu";
			this.addAuthenticatorMenu.Size = new System.Drawing.Size(61, 4);
			// 
			// optionsMenu
			// 
			this.optionsMenu.Name = "addMenu";
			this.optionsMenu.Size = new System.Drawing.Size(61, 4);
			this.optionsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.optionsMenu_Opening);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.notifyMenu;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "WinAuth";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// notifyMenu
			// 
			this.notifyMenu.Name = "notifyMenu";
			this.notifyMenu.Size = new System.Drawing.Size(61, 4);
			this.notifyMenu.Opening += new System.ComponentModel.CancelEventHandler(this.notifyMenu_Opening);
			// 
			// passwordTimer
			// 
			this.passwordTimer.Interval = 500;
			this.passwordTimer.Tick += new System.EventHandler(this.passwordTimer_Tick);
			// 
			// hotkeyTimer
			// 
			this.hotkeyTimer.Interval = 250;
			this.hotkeyTimer.Tick += new System.EventHandler(this.hotkeyTimer_Tick);
			// 
			// yubiPanel
			// 
			this.yubiPanel.Controls.Add(this.yubiRetryButton);
			this.yubiPanel.Controls.Add(this.yubiLabel);
			this.yubiPanel.Controls.Add(this.yubiImage);
			this.yubiPanel.Location = new System.Drawing.Point(20, 60);
			this.yubiPanel.Name = "yubiPanel";
			this.yubiPanel.Size = new System.Drawing.Size(380, 100);
			this.yubiPanel.TabIndex = 5;
			// 
			// yubiRetryButton
			// 
			this.yubiRetryButton.Location = new System.Drawing.Point(269, 49);
			this.yubiRetryButton.Name = "yubiRetryButton";
			this.yubiRetryButton.Size = new System.Drawing.Size(75, 23);
			this.yubiRetryButton.TabIndex = 5;
			this.yubiRetryButton.Text = "OK";
			this.yubiRetryButton.Click += new System.EventHandler(this.yubiRetryButton_Click);
			// 
			// yubiLabel
			// 
			this.yubiLabel.AutoSize = true;
			this.yubiLabel.Location = new System.Drawing.Point(13, 6);
			this.yubiLabel.Name = "yubiLabel";
			this.yubiLabel.Size = new System.Drawing.Size(324, 19);
			this.yubiLabel.TabIndex = 4;
			this.yubiLabel.Text = "Please insert your YubiKey or press the flashing button";
			// 
			// yubiImage
			// 
			this.yubiImage.Image = ((System.Drawing.Image)(resources.GetObject("yubiImage.Image")));
			this.yubiImage.Location = new System.Drawing.Point(12, 32);
			this.yubiImage.Name = "yubiImage";
			this.yubiImage.Size = new System.Drawing.Size(230, 60);
			this.yubiImage.TabIndex = 2;
			this.yubiImage.TabStop = false;
			// 
			// passwordPanel
			// 
			this.passwordPanel.Controls.Add(this.passwordButton);
			this.passwordPanel.Controls.Add(this.passwordErrorLabel);
			this.passwordPanel.Controls.Add(this.passwordLabel);
			this.passwordPanel.Controls.Add(this.passwordField);
			this.passwordPanel.Location = new System.Drawing.Point(20, 60);
			this.passwordPanel.Name = "passwordPanel";
			this.passwordPanel.Size = new System.Drawing.Size(380, 100);
			this.passwordPanel.TabIndex = 4;
			// 
			// passwordButton
			// 
			this.passwordButton.Location = new System.Drawing.Point(278, 40);
			this.passwordButton.Name = "passwordButton";
			this.passwordButton.Size = new System.Drawing.Size(75, 23);
			this.passwordButton.TabIndex = 1;
			this.passwordButton.Text = "OK";
			this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
			// 
			// passwordErrorLabel
			// 
			this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.passwordErrorLabel.Location = new System.Drawing.Point(27, 68);
			this.passwordErrorLabel.Name = "passwordErrorLabel";
			this.passwordErrorLabel.Size = new System.Drawing.Size(326, 19);
			this.passwordErrorLabel.TabIndex = 3;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(24, 16);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(63, 19);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "Password";
			// 
			// passwordField
			// 
			this.passwordField.Location = new System.Drawing.Point(27, 42);
			this.passwordField.MaxLength = 32767;
			this.passwordField.Name = "passwordField";
			this.passwordField.PasswordChar = '●';
			this.passwordField.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.passwordField.SelectedText = "";
			this.passwordField.Size = new System.Drawing.Size(236, 20);
			this.passwordField.TabIndex = 0;
			this.passwordField.UseSystemPasswordChar = true;
			this.passwordField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordField_KeyPress);
			// 
			// introLabel
			// 
			this.introLabel.Location = new System.Drawing.Point(23, 76);
			this.introLabel.Name = "introLabel";
			this.introLabel.Size = new System.Drawing.Size(377, 35);
			this.introLabel.TabIndex = 3;
			this.introLabel.Text = "Click the \"Add\" button to create or import your authenticator";
			this.introLabel.Visible = false;
			// 
			// commandPanel
			// 
			this.commandPanel.Controls.Add(this.newVersionLink);
			this.commandPanel.Controls.Add(this.optionsButton);
			this.commandPanel.Controls.Add(this.addAuthenticatorButton);
			this.commandPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.commandPanel.Location = new System.Drawing.Point(20, 128);
			this.commandPanel.Name = "commandPanel";
			this.commandPanel.Size = new System.Drawing.Size(380, 32);
			this.commandPanel.TabIndex = 1;
			this.commandPanel.Visible = false;
			this.commandPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.commandPanel_MouseDown);
			// 
			// newVersionLink
			// 
			this.newVersionLink.Cursor = System.Windows.Forms.Cursors.Hand;
			this.newVersionLink.Location = new System.Drawing.Point(90, 10);
			this.newVersionLink.Name = "newVersionLink";
			this.newVersionLink.Size = new System.Drawing.Size(225, 23);
			this.newVersionLink.TabIndex = 2;
			this.newVersionLink.Text = "New version is available";
			this.newVersionLink.Visible = false;
			this.newVersionLink.Click += new System.EventHandler(this.newVersionLink_Click);
			// 
			// optionsButton
			// 
			this.optionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.optionsButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.optionsButton.BackgroundImage = global::WinAuth.Properties.Resources.OptionsIcon;
			this.optionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.optionsButton.Location = new System.Drawing.Point(352, 9);
			this.optionsButton.Name = "optionsButton";
			this.optionsButton.Size = new System.Drawing.Size(28, 23);
			this.optionsButton.TabIndex = 0;
			this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
			// 
			// addAuthenticatorButton
			// 
			this.addAuthenticatorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addAuthenticatorButton.Location = new System.Drawing.Point(0, 9);
			this.addAuthenticatorButton.Name = "addAuthenticatorButton";
			this.addAuthenticatorButton.Size = new System.Drawing.Size(70, 23);
			this.addAuthenticatorButton.TabIndex = 0;
			this.addAuthenticatorButton.Text = "Add";
			this.addAuthenticatorButton.Click += new System.EventHandler(this.addAuthenticatorButton_Click);
			// 
			// authenticatorList
			// 
			this.authenticatorList.AllowDrop = true;
			this.authenticatorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.authenticatorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.authenticatorList.CurrentItem = null;
			this.authenticatorList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.authenticatorList.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
			this.authenticatorList.IntegralHeight = false;
			this.authenticatorList.ItemHeight = 64;
			this.authenticatorList.Location = new System.Drawing.Point(20, 60);
			this.authenticatorList.Name = "authenticatorList";
			this.authenticatorList.ReadOnly = false;
			this.authenticatorList.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.authenticatorList.Size = new System.Drawing.Size(380, 62);
			this.authenticatorList.TabIndex = 0;
			this.authenticatorList.TabStop = false;
			this.authenticatorList.Visible = false;
			this.authenticatorList.ItemRemoved += new WinAuth.AuthenticatorListItemRemovedHandler(this.authenticatorList_ItemRemoved);
			this.authenticatorList.Reordered += new WinAuth.AuthenticatorListReorderedHandler(this.authenticatorList_Reordered);
			// 
			// loadingPanel
			// 
			this.loadingPanel.Controls.Add(this.pictureBox1);
			this.loadingPanel.Location = new System.Drawing.Point(20, 60);
			this.loadingPanel.Name = "loadingPanel";
			this.loadingPanel.Size = new System.Drawing.Size(380, 100);
			this.loadingPanel.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WinAuth.Properties.Resources.spinner24;
			this.pictureBox1.Location = new System.Drawing.Point(178, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 25);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// WinAuthForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 180);
			this.Controls.Add(this.loadingPanel);
			this.Controls.Add(this.yubiPanel);
			this.Controls.Add(this.passwordPanel);
			this.Controls.Add(this.introLabel);
			this.Controls.Add(this.commandPanel);
			this.Controls.Add(this.authenticatorList);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1620, 1080);
			this.MinimumSize = new System.Drawing.Size(300, 180);
			this.Name = "WinAuthForm";
			this.Text = "WinAuth";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinAuthForm_FormClosing);
			this.Load += new System.EventHandler(this.WinAuthForm_Load);
			this.Shown += new System.EventHandler(this.WinAuthForm_Shown);
			this.ResizeEnd += new System.EventHandler(this.WinAuthForm_ResizeEnd);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinAuthForm_MouseDown);
			this.Resize += new System.EventHandler(this.WinAuthForm_Resize);
			this.authenticatorMenu.ResumeLayout(false);
			this.yubiPanel.ResumeLayout(false);
			this.yubiPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.yubiImage)).EndInit();
			this.passwordPanel.ResumeLayout(false);
			this.passwordPanel.PerformLayout();
			this.commandPanel.ResumeLayout(false);
			this.loadingPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

		private AuthenticatorListBox authenticatorList;
		private System.Windows.Forms.Timer mainTimer;
		private System.Windows.Forms.ContextMenuStrip authenticatorMenu;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.Panel commandPanel;
		private System.Windows.Forms.Button addAuthenticatorButton;
		private System.Windows.Forms.ContextMenuStrip addAuthenticatorMenu;
		private System.Windows.Forms.Button optionsButton;
		private System.Windows.Forms.ContextMenuStrip optionsMenu;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Label introLabel;
		private System.Windows.Forms.Panel passwordPanel;
		private System.Windows.Forms.TextBox passwordField;
		private System.Windows.Forms.Button passwordButton;
		private System.Windows.Forms.Label passwordErrorLabel;
		private System.Windows.Forms.Timer passwordTimer;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.ContextMenuStrip notifyMenu;
		private System.Windows.Forms.LinkLabel newVersionLink;
		private System.Windows.Forms.Timer hotkeyTimer;
		private System.Windows.Forms.Panel yubiPanel;
		private System.Windows.Forms.PictureBox yubiImage;
		private System.Windows.Forms.Button yubiRetryButton;
		private System.Windows.Forms.Label yubiLabel;
		private System.Windows.Forms.Panel loadingPanel;
		private System.Windows.Forms.PictureBox pictureBox1;

  }
}


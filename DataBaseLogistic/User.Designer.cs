namespace DataBaseLogistic
{
    partial class User
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
            this.UserManageControl = new MetroFramework.Controls.MetroTabControl();
            this.UserOrderTab = new MetroFramework.Controls.MetroTabPage();
            this.UserInformTab = new MetroFramework.Controls.MetroTabPage();
            this.UserMoneyTab = new MetroFramework.Controls.MetroTabPage();
            this.WelcomeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.UserManageControl.SuspendLayout();
            this.UserOrderTab.SuspendLayout();
            this.UserMoneyTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserManageControl
            // 
            this.UserManageControl.Controls.Add(this.UserOrderTab);
            this.UserManageControl.Controls.Add(this.UserInformTab);
            this.UserManageControl.Controls.Add(this.UserMoneyTab);
            this.UserManageControl.CustomBackground = false;
            this.UserManageControl.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.UserManageControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.UserManageControl.Location = new System.Drawing.Point(8, 63);
            this.UserManageControl.Multiline = true;
            this.UserManageControl.Name = "UserManageControl";
            this.UserManageControl.SelectedIndex = 0;
            this.UserManageControl.Size = new System.Drawing.Size(469, 258);
            this.UserManageControl.Style = MetroFramework.MetroColorStyle.Silver;
            this.UserManageControl.StyleManager = null;
            this.UserManageControl.TabIndex = 0;
            this.UserManageControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserManageControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserManageControl.UseStyleColors = false;
            // 
            // UserOrderTab
            // 
            this.UserOrderTab.Controls.Add(this.metroTile3);
            this.UserOrderTab.Controls.Add(this.metroTile2);
            this.UserOrderTab.CustomBackground = false;
            this.UserOrderTab.HorizontalScrollbar = false;
            this.UserOrderTab.HorizontalScrollbarBarColor = true;
            this.UserOrderTab.HorizontalScrollbarHighlightOnWheel = false;
            this.UserOrderTab.HorizontalScrollbarSize = 10;
            this.UserOrderTab.Location = new System.Drawing.Point(4, 36);
            this.UserOrderTab.Name = "UserOrderTab";
            this.UserOrderTab.Size = new System.Drawing.Size(461, 218);
            this.UserOrderTab.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserOrderTab.StyleManager = null;
            this.UserOrderTab.TabIndex = 0;
            this.UserOrderTab.Text = "订单管理";
            this.UserOrderTab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserOrderTab.VerticalScrollbar = false;
            this.UserOrderTab.VerticalScrollbarBarColor = true;
            this.UserOrderTab.VerticalScrollbarHighlightOnWheel = false;
            this.UserOrderTab.VerticalScrollbarSize = 10;
            // 
            // UserInformTab
            // 
            this.UserInformTab.CustomBackground = false;
            this.UserInformTab.HorizontalScrollbar = false;
            this.UserInformTab.HorizontalScrollbarBarColor = true;
            this.UserInformTab.HorizontalScrollbarHighlightOnWheel = false;
            this.UserInformTab.HorizontalScrollbarSize = 10;
            this.UserInformTab.Location = new System.Drawing.Point(4, 36);
            this.UserInformTab.Name = "UserInformTab";
            this.UserInformTab.Size = new System.Drawing.Size(461, 218);
            this.UserInformTab.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserInformTab.StyleManager = null;
            this.UserInformTab.TabIndex = 1;
            this.UserInformTab.Text = "个人信息";
            this.UserInformTab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserInformTab.VerticalScrollbar = false;
            this.UserInformTab.VerticalScrollbarBarColor = true;
            this.UserInformTab.VerticalScrollbarHighlightOnWheel = false;
            this.UserInformTab.VerticalScrollbarSize = 10;
            // 
            // UserMoneyTab
            // 
            this.UserMoneyTab.Controls.Add(this.metroTile1);
            this.UserMoneyTab.CustomBackground = false;
            this.UserMoneyTab.HorizontalScrollbar = false;
            this.UserMoneyTab.HorizontalScrollbarBarColor = true;
            this.UserMoneyTab.HorizontalScrollbarHighlightOnWheel = false;
            this.UserMoneyTab.HorizontalScrollbarSize = 10;
            this.UserMoneyTab.Location = new System.Drawing.Point(4, 36);
            this.UserMoneyTab.Name = "UserMoneyTab";
            this.UserMoneyTab.Size = new System.Drawing.Size(461, 218);
            this.UserMoneyTab.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserMoneyTab.StyleManager = null;
            this.UserMoneyTab.TabIndex = 2;
            this.UserMoneyTab.Text = "金额管理";
            this.UserMoneyTab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserMoneyTab.VerticalScrollbar = false;
            this.UserMoneyTab.VerticalScrollbarBarColor = true;
            this.UserMoneyTab.VerticalScrollbarHighlightOnWheel = false;
            this.UserMoneyTab.VerticalScrollbarSize = 10;
            // 
            // WelcomeNameLabel
            // 
            this.WelcomeNameLabel.AutoSize = true;
            this.WelcomeNameLabel.CustomBackground = false;
            this.WelcomeNameLabel.CustomForeColor = false;
            this.WelcomeNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WelcomeNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.WelcomeNameLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.WelcomeNameLabel.Location = new System.Drawing.Point(223, 22);
            this.WelcomeNameLabel.Name = "WelcomeNameLabel";
            this.WelcomeNameLabel.Size = new System.Drawing.Size(107, 25);
            this.WelcomeNameLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.WelcomeNameLabel.StyleManager = null;
            this.WelcomeNameLabel.TabIndex = 1;
            this.WelcomeNameLabel.Text = "欢迎回来，";
            this.WelcomeNameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WelcomeNameLabel.UseStyleColors = false;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTile1.CustomBackground = false;
            this.metroTile1.CustomForeColor = false;
            this.metroTile1.Location = new System.Drawing.Point(49, 51);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.PaintTileCount = true;
            this.metroTile1.Size = new System.Drawing.Size(138, 61);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.StyleManager = null;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "         查询余额\r\n";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileCount = 0;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTile2.CustomBackground = false;
            this.metroTile2.CustomForeColor = false;
            this.metroTile2.Location = new System.Drawing.Point(42, 48);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.PaintTileCount = true;
            this.metroTile2.Size = new System.Drawing.Size(140, 63);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.StyleManager = null;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "            新订单\r\n";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileCount = 0;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTile3.CustomBackground = false;
            this.metroTile3.CustomForeColor = false;
            this.metroTile3.Location = new System.Drawing.Point(211, 48);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.PaintTileCount = true;
            this.metroTile3.Size = new System.Drawing.Size(140, 63);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile3.StyleManager = null;
            this.metroTile3.TabIndex = 4;
            this.metroTile3.Text = "         查询订单\r\n";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile3.TileCount = 0;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 331);
            this.Controls.Add(this.WelcomeNameLabel);
            this.Controls.Add(this.UserManageControl);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "User";
            this.UserManageControl.ResumeLayout(false);
            this.UserOrderTab.ResumeLayout(false);
            this.UserMoneyTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl UserManageControl;
        private MetroFramework.Controls.MetroTabPage UserOrderTab;
        private MetroFramework.Controls.MetroTabPage UserInformTab;
        private MetroFramework.Controls.MetroTabPage UserMoneyTab;
        private MetroFramework.Controls.MetroLabel WelcomeNameLabel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}
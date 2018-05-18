namespace CS.UI
{
    partial class LogIn
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
            this.Btn_login = new MetroFramework.Controls.MetroTile();
            this.Txb_account = new MetroFramework.Controls.MetroTextBox();
            this.lbl_account = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Txb_pwd = new MetroFramework.Controls.MetroTextBox();
            this.Btn_cancel = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Btn_login
            // 
            this.Btn_login.ActiveControl = null;
            this.Btn_login.Location = new System.Drawing.Point(179, 300);
            this.Btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(80, 35);
            this.Btn_login.TabIndex = 0;
            this.Btn_login.Text = "登陆";
            this.Btn_login.UseSelectable = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Txb_account
            // 
            // 
            // 
            // 
            this.Txb_account.CustomButton.Image = null;
            this.Txb_account.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.Txb_account.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.Txb_account.CustomButton.Name = "";
            this.Txb_account.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.Txb_account.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txb_account.CustomButton.TabIndex = 1;
            this.Txb_account.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txb_account.CustomButton.UseSelectable = true;
            this.Txb_account.CustomButton.Visible = false;
            this.Txb_account.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Txb_account.Lines = new string[0];
            this.Txb_account.Location = new System.Drawing.Point(106, 121);
            this.Txb_account.Margin = new System.Windows.Forms.Padding(4);
            this.Txb_account.MaxLength = 32767;
            this.Txb_account.Name = "Txb_account";
            this.Txb_account.PasswordChar = '\0';
            this.Txb_account.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txb_account.SelectedText = "";
            this.Txb_account.SelectionLength = 0;
            this.Txb_account.SelectionStart = 0;
            this.Txb_account.Size = new System.Drawing.Size(149, 31);
            this.Txb_account.TabIndex = 1;
            this.Txb_account.UseSelectable = true;
            this.Txb_account.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txb_account.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Location = new System.Drawing.Point(46, 127);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(37, 19);
            this.lbl_account.TabIndex = 2;
            this.lbl_account.Text = "账号";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 209);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "密码";
            // 
            // Txb_pwd
            // 
            // 
            // 
            // 
            this.Txb_pwd.CustomButton.Image = null;
            this.Txb_pwd.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.Txb_pwd.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.Txb_pwd.CustomButton.Name = "";
            this.Txb_pwd.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.Txb_pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txb_pwd.CustomButton.TabIndex = 1;
            this.Txb_pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txb_pwd.CustomButton.UseSelectable = true;
            this.Txb_pwd.CustomButton.Visible = false;
            this.Txb_pwd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Txb_pwd.Lines = new string[0];
            this.Txb_pwd.Location = new System.Drawing.Point(106, 203);
            this.Txb_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.Txb_pwd.MaxLength = 32767;
            this.Txb_pwd.Name = "Txb_pwd";
            this.Txb_pwd.PasswordChar = '\0';
            this.Txb_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txb_pwd.SelectedText = "";
            this.Txb_pwd.SelectionLength = 0;
            this.Txb_pwd.SelectionStart = 0;
            this.Txb_pwd.Size = new System.Drawing.Size(149, 31);
            this.Txb_pwd.TabIndex = 3;
            this.Txb_pwd.UseSelectable = true;
            this.Txb_pwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txb_pwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.ActiveControl = null;
            this.Btn_cancel.Location = new System.Drawing.Point(46, 300);
            this.Btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(80, 35);
            this.Btn_cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Btn_cancel.TabIndex = 5;
            this.Btn_cancel.Text = "取消";
            this.Btn_cancel.UseSelectable = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Txb_pwd);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.Txb_account);
            this.Controls.Add(this.Btn_login);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile Btn_login;
        private MetroFramework.Controls.MetroTextBox Txb_account;
        private MetroFramework.Controls.MetroLabel lbl_account;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox Txb_pwd;
        private MetroFramework.Controls.MetroTile Btn_cancel;
    }
}
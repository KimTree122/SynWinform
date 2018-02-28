namespace DsParkOffLine
{
    partial class DelConfirm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txb_pwd = new MetroFramework.Controls.MetroTextBox();
            this.btn_enter = new MetroFramework.Controls.MetroTile();
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 90);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "密码";
            // 
            // txb_pwd
            // 
            // 
            // 
            // 
            this.txb_pwd.CustomButton.Image = null;
            this.txb_pwd.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txb_pwd.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txb_pwd.CustomButton.Name = "";
            this.txb_pwd.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txb_pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_pwd.CustomButton.TabIndex = 1;
            this.txb_pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_pwd.CustomButton.UseSelectable = true;
            this.txb_pwd.CustomButton.Visible = false;
            this.txb_pwd.Lines = new string[0];
            this.txb_pwd.Location = new System.Drawing.Point(114, 84);
            this.txb_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txb_pwd.MaxLength = 10;
            this.txb_pwd.Name = "txb_pwd";
            this.txb_pwd.PasswordChar = '*';
            this.txb_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_pwd.SelectedText = "";
            this.txb_pwd.SelectionLength = 0;
            this.txb_pwd.SelectionStart = 0;
            this.txb_pwd.Size = new System.Drawing.Size(155, 31);
            this.txb_pwd.TabIndex = 1;
            this.txb_pwd.UseSelectable = true;
            this.txb_pwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_pwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_enter
            // 
            this.btn_enter.ActiveControl = null;
            this.btn_enter.Location = new System.Drawing.Point(195, 135);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 46);
            this.btn_enter.TabIndex = 9;
            this.btn_enter.Text = "确定";
            this.btn_enter.UseSelectable = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveControl = null;
            this.btn_cancel.Location = new System.Drawing.Point(30, 135);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 46);
            this.btn_cancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseSelectable = true;
            // 
            // DelConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txb_pwd);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DelConfirm";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "登记删除";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txb_pwd;
        private MetroFramework.Controls.MetroTile btn_enter;
        private MetroFramework.Controls.MetroTile btn_cancel;
    }
}
namespace DsParkOffLine
{
    partial class BlackList
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
            this.txb_Name = new MetroFramework.Controls.MetroTextBox();
            this.txb_ID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.btn_enter = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(40, 115);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "姓名";
            // 
            // txb_Name
            // 
            // 
            // 
            // 
            this.txb_Name.CustomButton.Image = null;
            this.txb_Name.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txb_Name.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Name.CustomButton.Name = "";
            this.txb_Name.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txb_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_Name.CustomButton.TabIndex = 1;
            this.txb_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_Name.CustomButton.UseSelectable = true;
            this.txb_Name.CustomButton.Visible = false;
            this.txb_Name.Lines = new string[0];
            this.txb_Name.Location = new System.Drawing.Point(100, 109);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Name.MaxLength = 32767;
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.PasswordChar = '\0';
            this.txb_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_Name.SelectedText = "";
            this.txb_Name.SelectionLength = 0;
            this.txb_Name.SelectionStart = 0;
            this.txb_Name.Size = new System.Drawing.Size(180, 31);
            this.txb_Name.TabIndex = 1;
            this.txb_Name.UseSelectable = true;
            this.txb_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_ID
            // 
            // 
            // 
            // 
            this.txb_ID.CustomButton.Image = null;
            this.txb_ID.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txb_ID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ID.CustomButton.Name = "";
            this.txb_ID.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txb_ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_ID.CustomButton.TabIndex = 1;
            this.txb_ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_ID.CustomButton.UseSelectable = true;
            this.txb_ID.CustomButton.Visible = false;
            this.txb_ID.Lines = new string[0];
            this.txb_ID.Location = new System.Drawing.Point(100, 161);
            this.txb_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ID.MaxLength = 32767;
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.PasswordChar = '\0';
            this.txb_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_ID.SelectedText = "";
            this.txb_ID.SelectionLength = 0;
            this.txb_ID.SelectionStart = 0;
            this.txb_ID.Size = new System.Drawing.Size(180, 31);
            this.txb_ID.TabIndex = 3;
            this.txb_ID.UseSelectable = true;
            this.txb_ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(40, 167);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "身份证";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 216);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "日期";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(100, 216);
            this.dtp.Margin = new System.Windows.Forms.Padding(4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(180, 26);
            this.dtp.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveControl = null;
            this.btn_cancel.Location = new System.Drawing.Point(40, 296);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 46);
            this.btn_cancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "退出";
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.ActiveControl = null;
            this.btn_enter.Location = new System.Drawing.Point(205, 296);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 46);
            this.btn_enter.TabIndex = 7;
            this.btn_enter.Text = "确定";
            this.btn_enter.UseSelectable = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // BlackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 400);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txb_ID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BlackList";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "黑名单";
            this.Load += new System.EventHandler(this.BlackList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txb_Name;
        private MetroFramework.Controls.MetroTextBox txb_ID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dtp;
        private MetroFramework.Controls.MetroTile btn_cancel;
        private MetroFramework.Controls.MetroTile btn_enter;
    }
}
namespace SynDSStudent
{
    partial class CheckStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckStudent));
            this.mps = new MetroFramework.Controls.MetroProgressSpinner();
            this.btn_start = new MetroFramework.Controls.MetroTile();
            this.btn_exist = new MetroFramework.Controls.MetroTile();
            this.btn_download = new MetroFramework.Controls.MetroTile();
            this.btn_rc = new MetroFramework.Controls.MetroTile();
            this.lbl_name = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_his = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // mps
            // 
            this.mps.Location = new System.Drawing.Point(51, 83);
            this.mps.Maximum = 100;
            this.mps.Name = "mps";
            this.mps.Size = new System.Drawing.Size(150, 150);
            this.mps.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mps.TabIndex = 0;
            this.mps.UseSelectable = true;
            // 
            // btn_start
            // 
            this.btn_start.ActiveControl = null;
            this.btn_start.Location = new System.Drawing.Point(51, 303);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(80, 50);
            this.btn_start.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "开始";
            this.btn_start.UseSelectable = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_exist
            // 
            this.btn_exist.ActiveControl = null;
            this.btn_exist.Location = new System.Drawing.Point(361, 303);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(80, 50);
            this.btn_exist.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_exist.TabIndex = 2;
            this.btn_exist.Text = "退出";
            this.btn_exist.UseSelectable = true;
            // 
            // btn_download
            // 
            this.btn_download.ActiveControl = null;
            this.btn_download.Location = new System.Drawing.Point(146, 303);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(80, 50);
            this.btn_download.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_download.TabIndex = 3;
            this.btn_download.Text = "重新加载";
            this.btn_download.UseSelectable = true;
            // 
            // btn_rc
            // 
            this.btn_rc.ActiveControl = null;
            this.btn_rc.Location = new System.Drawing.Point(253, 303);
            this.btn_rc.Name = "btn_rc";
            this.btn_rc.Size = new System.Drawing.Size(80, 50);
            this.btn_rc.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_rc.TabIndex = 4;
            this.btn_rc.Text = "读卡";
            this.btn_rc.UseSelectable = true;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(418, 83);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "未读取";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(361, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 20);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "记录：";
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(232, 83);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(123, 150);
            this.picbox.TabIndex = 7;
            this.picbox.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(361, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "姓名：";
            // 
            // lbl_his
            // 
            this.lbl_his.AutoSize = true;
            this.lbl_his.Location = new System.Drawing.Point(418, 121);
            this.lbl_his.Name = "lbl_his";
            this.lbl_his.Size = new System.Drawing.Size(51, 20);
            this.lbl_his.TabIndex = 9;
            this.lbl_his.Text = "未读取";
            // 
            // CheckStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 400);
            this.Controls.Add(this.lbl_his);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_rc);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.mps);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckStudent";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "检查登记";
            this.Load += new System.EventHandler(this.CheckStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner mps;
        private MetroFramework.Controls.MetroTile btn_start;
        private MetroFramework.Controls.MetroTile btn_exist;
        private MetroFramework.Controls.MetroTile btn_download;
        private MetroFramework.Controls.MetroTile btn_rc;
        private MetroFramework.Controls.MetroLabel lbl_name;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox picbox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl_his;
    }
}
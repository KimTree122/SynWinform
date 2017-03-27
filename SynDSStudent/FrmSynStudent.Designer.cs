namespace SynDSStudent
{
    partial class FrmSynStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSynStudent));
            this.gb_locat = new System.Windows.Forms.GroupBox();
            this.progress = new MetroFramework.Controls.MetroProgressSpinner();
            this.lbl_local_count = new System.Windows.Forms.Label();
            this.lbl_local_ver = new System.Windows.Forms.Label();
            this.btn_auto = new MetroFramework.Controls.MetroTile();
            this.btn_version = new MetroFramework.Controls.MetroTile();
            this.btn_allload = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_serversion = new MetroFramework.Controls.MetroTile();
            this.gb_server = new System.Windows.Forms.GroupBox();
            this.lbl_ser_count = new System.Windows.Forms.Label();
            this.lbl_ser_ver = new System.Windows.Forms.Label();
            this.mlbl_title = new System.Windows.Forms.Label();
            this.gb_locat.SuspendLayout();
            this.gb_server.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_locat
            // 
            this.gb_locat.Controls.Add(this.progress);
            this.gb_locat.Controls.Add(this.lbl_local_count);
            this.gb_locat.Controls.Add(this.lbl_local_ver);
            this.gb_locat.Controls.Add(this.btn_auto);
            this.gb_locat.Controls.Add(this.btn_version);
            this.gb_locat.Controls.Add(this.btn_allload);
            this.gb_locat.Controls.Add(this.metroLabel5);
            this.gb_locat.Controls.Add(this.metroLabel2);
            this.gb_locat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_locat.Location = new System.Drawing.Point(27, 164);
            this.gb_locat.Margin = new System.Windows.Forms.Padding(4);
            this.gb_locat.Name = "gb_locat";
            this.gb_locat.Padding = new System.Windows.Forms.Padding(4);
            this.gb_locat.Size = new System.Drawing.Size(479, 260);
            this.gb_locat.TabIndex = 3;
            this.gb_locat.TabStop = false;
            this.gb_locat.Text = "本地数据";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(197, 26);
            this.progress.Maximum = 100;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(105, 98);
            this.progress.Style = MetroFramework.MetroColorStyle.Teal;
            this.progress.TabIndex = 15;
            this.progress.UseSelectable = true;
            this.progress.Value = 80;
            this.progress.Visible = false;
            // 
            // lbl_local_count
            // 
            this.lbl_local_count.AutoSize = true;
            this.lbl_local_count.Location = new System.Drawing.Point(135, 100);
            this.lbl_local_count.Name = "lbl_local_count";
            this.lbl_local_count.Size = new System.Drawing.Size(0, 16);
            this.lbl_local_count.TabIndex = 14;
            // 
            // lbl_local_ver
            // 
            this.lbl_local_ver.AutoSize = true;
            this.lbl_local_ver.Location = new System.Drawing.Point(135, 48);
            this.lbl_local_ver.Name = "lbl_local_ver";
            this.lbl_local_ver.Size = new System.Drawing.Size(0, 16);
            this.lbl_local_ver.TabIndex = 13;
            // 
            // btn_auto
            // 
            this.btn_auto.ActiveControl = null;
            this.btn_auto.Location = new System.Drawing.Point(315, 171);
            this.btn_auto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(128, 60);
            this.btn_auto.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btn_auto.TabIndex = 10;
            this.btn_auto.Text = "自动同步";
            this.btn_auto.UseSelectable = true;
            this.btn_auto.Click += new System.EventHandler(this.btn_auto_Click);
            // 
            // btn_version
            // 
            this.btn_version.ActiveControl = null;
            this.btn_version.Location = new System.Drawing.Point(176, 171);
            this.btn_version.Margin = new System.Windows.Forms.Padding(4);
            this.btn_version.Name = "btn_version";
            this.btn_version.Size = new System.Drawing.Size(128, 60);
            this.btn_version.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_version.TabIndex = 9;
            this.btn_version.Text = "差异同步";
            this.btn_version.UseSelectable = true;
            this.btn_version.Click += new System.EventHandler(this.btn_version_Click);
            // 
            // btn_allload
            // 
            this.btn_allload.ActiveControl = null;
            this.btn_allload.Location = new System.Drawing.Point(37, 171);
            this.btn_allload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_allload.Name = "btn_allload";
            this.btn_allload.Size = new System.Drawing.Size(128, 60);
            this.btn_allload.TabIndex = 6;
            this.btn_allload.Text = "全部获取";
            this.btn_allload.UseSelectable = true;
            this.btn_allload.Click += new System.EventHandler(this.btn_allload_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(33, 98);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "学员数量：";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 46);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "本地版本：";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "学员同步";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 23);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "最新版本：";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(200, 23);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "学员数量：";
            // 
            // btn_serversion
            // 
            this.btn_serversion.ActiveControl = null;
            this.btn_serversion.Location = new System.Drawing.Point(315, 12);
            this.btn_serversion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_serversion.Name = "btn_serversion";
            this.btn_serversion.Size = new System.Drawing.Size(128, 60);
            this.btn_serversion.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_serversion.TabIndex = 10;
            this.btn_serversion.Text = "最新数据";
            this.btn_serversion.UseSelectable = true;
            this.btn_serversion.Click += new System.EventHandler(this.btn_serversion_Click);
            // 
            // gb_server
            // 
            this.gb_server.Controls.Add(this.lbl_ser_count);
            this.gb_server.Controls.Add(this.lbl_ser_ver);
            this.gb_server.Controls.Add(this.btn_serversion);
            this.gb_server.Controls.Add(this.metroLabel3);
            this.gb_server.Controls.Add(this.metroLabel1);
            this.gb_server.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_server.Location = new System.Drawing.Point(27, 80);
            this.gb_server.Margin = new System.Windows.Forms.Padding(5);
            this.gb_server.Name = "gb_server";
            this.gb_server.Padding = new System.Windows.Forms.Padding(5);
            this.gb_server.Size = new System.Drawing.Size(479, 84);
            this.gb_server.TabIndex = 2;
            this.gb_server.TabStop = false;
            this.gb_server.Text = "服务器数据";
            // 
            // lbl_ser_count
            // 
            this.lbl_ser_count.AutoSize = true;
            this.lbl_ser_count.ForeColor = System.Drawing.Color.Green;
            this.lbl_ser_count.Location = new System.Drawing.Point(200, 56);
            this.lbl_ser_count.Name = "lbl_ser_count";
            this.lbl_ser_count.Size = new System.Drawing.Size(0, 16);
            this.lbl_ser_count.TabIndex = 12;
            // 
            // lbl_ser_ver
            // 
            this.lbl_ser_ver.AutoSize = true;
            this.lbl_ser_ver.ForeColor = System.Drawing.Color.Green;
            this.lbl_ser_ver.Location = new System.Drawing.Point(37, 56);
            this.lbl_ser_ver.Name = "lbl_ser_ver";
            this.lbl_ser_ver.Size = new System.Drawing.Size(0, 16);
            this.lbl_ser_ver.TabIndex = 11;
            // 
            // mlbl_title
            // 
            this.mlbl_title.AutoSize = true;
            this.mlbl_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.mlbl_title.Location = new System.Drawing.Point(266, 34);
            this.mlbl_title.Name = "mlbl_title";
            this.mlbl_title.Size = new System.Drawing.Size(0, 16);
            this.mlbl_title.TabIndex = 4;
            // 
            // FrmSynStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 451);
            this.Controls.Add(this.mlbl_title);
            this.Controls.Add(this.gb_locat);
            this.Controls.Add(this.gb_server);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSynStudent";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Resizable = false;
            this.Text = "同步学员";
            this.Load += new System.EventHandler(this.FrmSynStudent_Load);
            this.SizeChanged += new System.EventHandler(this.FrmSynStudent_SizeChanged);
            this.gb_locat.ResumeLayout(false);
            this.gb_locat.PerformLayout();
            this.gb_server.ResumeLayout(false);
            this.gb_server.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_locat;
        private MetroFramework.Controls.MetroTile btn_version;
        private MetroFramework.Controls.MetroTile btn_allload;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btn_auto;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lbl_local_count;
        private System.Windows.Forms.Label lbl_local_ver;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile btn_serversion;
        private System.Windows.Forms.GroupBox gb_server;
        private System.Windows.Forms.Label lbl_ser_count;
        private System.Windows.Forms.Label lbl_ser_ver;
        private MetroFramework.Controls.MetroProgressSpinner progress;
        private System.Windows.Forms.Label mlbl_title;
    }
}
namespace MyDataSer
{
    partial class DataPostSer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPostSer));
            this.mps = new MetroFramework.Controls.MetroProgressSpinner();
            this.mbtn_start = new MetroFramework.Controls.MetroTile();
            this.mbtn_minsmall = new MetroFramework.Controls.MetroTile();
            this.PostTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mbtn_upload = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mps
            // 
            this.mps.EnsureVisible = false;
            this.mps.Location = new System.Drawing.Point(84, 78);
            this.mps.Maximum = 100;
            this.mps.Name = "mps";
            this.mps.Size = new System.Drawing.Size(150, 150);
            this.mps.TabIndex = 8;
            this.mps.UseSelectable = true;
            // 
            // mbtn_start
            // 
            this.mbtn_start.ActiveControl = null;
            this.mbtn_start.Location = new System.Drawing.Point(29, 241);
            this.mbtn_start.Name = "mbtn_start";
            this.mbtn_start.Size = new System.Drawing.Size(80, 40);
            this.mbtn_start.Style = MetroFramework.MetroColorStyle.Green;
            this.mbtn_start.TabIndex = 9;
            this.mbtn_start.Text = "服务开始";
            this.mbtn_start.UseSelectable = true;
            this.mbtn_start.Click += new System.EventHandler(this.mbtn_start_Click);
            // 
            // mbtn_minsmall
            // 
            this.mbtn_minsmall.ActiveControl = null;
            this.mbtn_minsmall.Location = new System.Drawing.Point(217, 241);
            this.mbtn_minsmall.Name = "mbtn_minsmall";
            this.mbtn_minsmall.Size = new System.Drawing.Size(80, 40);
            this.mbtn_minsmall.Style = MetroFramework.MetroColorStyle.Orange;
            this.mbtn_minsmall.TabIndex = 10;
            this.mbtn_minsmall.Text = "最小化";
            this.mbtn_minsmall.UseSelectable = true;
            this.mbtn_minsmall.Click += new System.EventHandler(this.mbtn_minsmall_Click);
            // 
            // PostTimer
            // 
            this.PostTimer.Interval = 2160000;
            this.PostTimer.Tick += new System.EventHandler(this.PostTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // mbtn_upload
            // 
            this.mbtn_upload.ActiveControl = null;
            this.mbtn_upload.Location = new System.Drawing.Point(123, 241);
            this.mbtn_upload.Name = "mbtn_upload";
            this.mbtn_upload.Size = new System.Drawing.Size(80, 40);
            this.mbtn_upload.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mbtn_upload.TabIndex = 11;
            this.mbtn_upload.Text = "手动上传";
            this.mbtn_upload.UseSelectable = true;
            this.mbtn_upload.Click += new System.EventHandler(this.mbtn_upload_Click);
            // 
            // DataPostSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 307);
            this.Controls.Add(this.mbtn_upload);
            this.Controls.Add(this.mbtn_minsmall);
            this.Controls.Add(this.mbtn_start);
            this.Controls.Add(this.mps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DataPostSer";
            this.Text = "同步服务器";
            this.Load += new System.EventHandler(this.DataPostSer_Load);
            this.SizeChanged += new System.EventHandler(this.DataPostSer_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner mps;
        private MetroFramework.Controls.MetroTile mbtn_start;
        private MetroFramework.Controls.MetroTile mbtn_minsmall;
        private System.Windows.Forms.Timer PostTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroTile mbtn_upload;

    }
}
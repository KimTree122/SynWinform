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
            this.list_history = new System.Windows.Forms.ListView();
            this.txb_serid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_dbid = new System.Windows.Forms.TextBox();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btn_get = new MetroFramework.Controls.MetroButton();
            this.btn_upload = new MetroFramework.Controls.MetroButton();
            this.btn_maxid = new MetroFramework.Controls.MetroButton();
            this.checkbox = new MetroFramework.Controls.MetroCheckBox();
            this.gb_text = new System.Windows.Forms.GroupBox();
            this.gb_text.SuspendLayout();
            this.SuspendLayout();
            // 
            // mps
            // 
            this.mps.EnsureVisible = false;
            this.mps.Location = new System.Drawing.Point(33, 78);
            this.mps.Maximum = 100;
            this.mps.Name = "mps";
            this.mps.Size = new System.Drawing.Size(150, 150);
            this.mps.TabIndex = 8;
            this.mps.UseSelectable = true;
            // 
            // mbtn_start
            // 
            this.mbtn_start.ActiveControl = null;
            this.mbtn_start.Location = new System.Drawing.Point(29, 292);
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
            this.mbtn_minsmall.Location = new System.Drawing.Point(261, 290);
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
            this.mbtn_upload.Location = new System.Drawing.Point(145, 292);
            this.mbtn_upload.Name = "mbtn_upload";
            this.mbtn_upload.Size = new System.Drawing.Size(80, 40);
            this.mbtn_upload.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mbtn_upload.TabIndex = 11;
            this.mbtn_upload.Text = "手动上传";
            this.mbtn_upload.UseSelectable = true;
            this.mbtn_upload.Click += new System.EventHandler(this.mbtn_upload_Click);
            // 
            // list_history
            // 
            this.list_history.Location = new System.Drawing.Point(188, 63);
            this.list_history.Name = "list_history";
            this.list_history.Size = new System.Drawing.Size(153, 208);
            this.list_history.TabIndex = 12;
            this.list_history.UseCompatibleStateImageBehavior = false;
            // 
            // txb_serid
            // 
            this.txb_serid.Location = new System.Drawing.Point(15, 56);
            this.txb_serid.Name = "txb_serid";
            this.txb_serid.Size = new System.Drawing.Size(100, 21);
            this.txb_serid.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "serid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "dbid";
            // 
            // txb_dbid
            // 
            this.txb_dbid.Location = new System.Drawing.Point(15, 97);
            this.txb_dbid.Name = "txb_dbid";
            this.txb_dbid.Size = new System.Drawing.Size(100, 21);
            this.txb_dbid.TabIndex = 15;
            // 
            // rtb
            // 
            this.rtb.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtb.Location = new System.Drawing.Point(117, 17);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(183, 250);
            this.rtb.TabIndex = 17;
            this.rtb.Text = "";
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(28, 124);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 40);
            this.btn_get.TabIndex = 18;
            this.btn_get.Text = "查询";
            this.btn_get.UseSelectable = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(28, 170);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 40);
            this.btn_upload.TabIndex = 19;
            this.btn_upload.Text = "上传";
            this.btn_upload.UseSelectable = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_maxid
            // 
            this.btn_maxid.Location = new System.Drawing.Point(28, 216);
            this.btn_maxid.Name = "btn_maxid";
            this.btn_maxid.Size = new System.Drawing.Size(75, 40);
            this.btn_maxid.TabIndex = 20;
            this.btn_maxid.Text = "最大ID";
            this.btn_maxid.UseSelectable = true;
            this.btn_maxid.Click += new System.EventHandler(this.btn_maxid_Click);
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Checked = true;
            this.checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox.Location = new System.Drawing.Point(41, 20);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(48, 17);
            this.checkbox.TabIndex = 21;
            this.checkbox.Text = "学员";
            this.checkbox.UseSelectable = true;
            // 
            // gb_text
            // 
            this.gb_text.Controls.Add(this.txb_serid);
            this.gb_text.Controls.Add(this.btn_maxid);
            this.gb_text.Controls.Add(this.checkbox);
            this.gb_text.Controls.Add(this.btn_upload);
            this.gb_text.Controls.Add(this.btn_get);
            this.gb_text.Controls.Add(this.label1);
            this.gb_text.Controls.Add(this.txb_dbid);
            this.gb_text.Controls.Add(this.label2);
            this.gb_text.Controls.Add(this.rtb);
            this.gb_text.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_text.Location = new System.Drawing.Point(347, 60);
            this.gb_text.Name = "gb_text";
            this.gb_text.Size = new System.Drawing.Size(303, 270);
            this.gb_text.TabIndex = 22;
            this.gb_text.TabStop = false;
            this.gb_text.Text = "数据调试";
            // 
            // DataPostSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 350);
            this.Controls.Add(this.gb_text);
            this.Controls.Add(this.list_history);
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
            this.gb_text.ResumeLayout(false);
            this.gb_text.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner mps;
        private MetroFramework.Controls.MetroTile mbtn_start;
        private MetroFramework.Controls.MetroTile mbtn_minsmall;
        private System.Windows.Forms.Timer PostTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroTile mbtn_upload;
        private System.Windows.Forms.ListView list_history;
        private System.Windows.Forms.TextBox txb_serid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_dbid;
        private System.Windows.Forms.RichTextBox rtb;
        private MetroFramework.Controls.MetroButton btn_get;
        private MetroFramework.Controls.MetroButton btn_upload;
        private MetroFramework.Controls.MetroButton btn_maxid;
        private MetroFramework.Controls.MetroCheckBox checkbox;
        private System.Windows.Forms.GroupBox gb_text;

    }
}
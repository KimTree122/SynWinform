namespace CS.UI.SYS
{
    partial class FrmUpgrade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxb_note = new System.Windows.Forms.RichTextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.proBar = new MetroFramework.Controls.MetroProgressBar();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_state = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txb_ver = new MetroFramework.Controls.MetroTextBox();
            this.btn_file = new MetroFramework.Controls.MetroTile();
            this.btn_upload = new MetroFramework.Controls.MetroTile();
            this.cb_zip = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxb_note);
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Controls.Add(this.proBar);
            this.groupBox1.Controls.Add(this.metroPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(27, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rtxb_note
            // 
            this.rtxb_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxb_note.Location = new System.Drawing.Point(224, 120);
            this.rtxb_note.Name = "rtxb_note";
            this.rtxb_note.Size = new System.Drawing.Size(219, 170);
            this.rtxb_note.TabIndex = 4;
            this.rtxb_note.Text = "";
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView.Location = new System.Drawing.Point(3, 120);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(221, 170);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // proBar
            // 
            this.proBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.proBar.Location = new System.Drawing.Point(3, 97);
            this.proBar.Name = "proBar";
            this.proBar.Size = new System.Drawing.Size(440, 23);
            this.proBar.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cb_zip);
            this.metroPanel1.Controls.Add(this.lbl_state);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txb_ver);
            this.metroPanel1.Controls.Add(this.btn_file);
            this.metroPanel1.Controls.Add(this.btn_upload);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 22);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(440, 75);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(3, 48);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(37, 19);
            this.lbl_state.TabIndex = 6;
            this.lbl_state.Text = "状态";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(32, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Ver:";
            // 
            // txb_ver
            // 
            // 
            // 
            // 
            this.txb_ver.CustomButton.Image = null;
            this.txb_ver.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txb_ver.CustomButton.Name = "";
            this.txb_ver.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_ver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_ver.CustomButton.TabIndex = 1;
            this.txb_ver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_ver.CustomButton.UseSelectable = true;
            this.txb_ver.CustomButton.Visible = false;
            this.txb_ver.Lines = new string[0];
            this.txb_ver.Location = new System.Drawing.Point(41, 16);
            this.txb_ver.MaxLength = 32767;
            this.txb_ver.Name = "txb_ver";
            this.txb_ver.PasswordChar = '\0';
            this.txb_ver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_ver.SelectedText = "";
            this.txb_ver.SelectionLength = 0;
            this.txb_ver.SelectionStart = 0;
            this.txb_ver.Size = new System.Drawing.Size(114, 23);
            this.txb_ver.TabIndex = 4;
            this.txb_ver.UseSelectable = true;
            this.txb_ver.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_ver.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_file
            // 
            this.btn_file.ActiveControl = null;
            this.btn_file.Location = new System.Drawing.Point(281, 16);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(60, 23);
            this.btn_file.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_file.TabIndex = 3;
            this.btn_file.Text = "文件";
            this.btn_file.UseSelectable = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.ActiveControl = null;
            this.btn_upload.Location = new System.Drawing.Point(363, 16);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(60, 23);
            this.btn_upload.TabIndex = 2;
            this.btn_upload.Text = "上传";
            this.btn_upload.UseSelectable = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // cb_zip
            // 
            this.cb_zip.AutoSize = true;
            this.cb_zip.Checked = true;
            this.cb_zip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_zip.Location = new System.Drawing.Point(193, 20);
            this.cb_zip.Name = "cb_zip";
            this.cb_zip.Size = new System.Drawing.Size(49, 15);
            this.cb_zip.TabIndex = 7;
            this.cb_zip.Text = "压缩";
            this.cb_zip.UseSelectable = true;
            // 
            // FrmUpgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUpgrade";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "升级管理";
            this.Load += new System.EventHandler(this.FrmUpgrade_Load);
            this.groupBox1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txb_ver;
        private MetroFramework.Controls.MetroTile btn_file;
        private MetroFramework.Controls.MetroTile btn_upload;
        private MetroFramework.Controls.MetroProgressBar proBar;
        private MetroFramework.Controls.MetroLabel lbl_state;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.RichTextBox rtxb_note;
        private MetroFramework.Controls.MetroCheckBox cb_zip;
    }
}
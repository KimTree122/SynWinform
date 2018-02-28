namespace DsParkOffLine
{
    partial class ParkStudent
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkStudent));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_clear = new MetroFramework.Controls.MetroTile();
            this.btn_del = new MetroFramework.Controls.MetroTile();
            this.mbtn_blacklist = new MetroFramework.Controls.MetroTile();
            this.mbtn_import = new MetroFramework.Controls.MetroTile();
            this.listView = new System.Windows.Forms.ListView();
            this.lbl_NO = new MetroFramework.Controls.MetroLabel();
            this.lbl_name = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mbtn_get = new MetroFramework.Controls.MetroTile();
            this.txb_select = new MetroFramework.Controls.MetroTextBox();
            this.mpbar = new MetroFramework.Controls.MetroProgressBar();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_clear);
            this.metroPanel1.Controls.Add(this.btn_del);
            this.metroPanel1.Controls.Add(this.mbtn_blacklist);
            this.metroPanel1.Controls.Add(this.mbtn_import);
            this.metroPanel1.Controls.Add(this.listView);
            this.metroPanel1.Controls.Add(this.lbl_NO);
            this.metroPanel1.Controls.Add(this.lbl_name);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.mbtn_get);
            this.metroPanel1.Controls.Add(this.txb_select);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(27, 80);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(426, 208);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveControl = null;
            this.btn_clear.Location = new System.Drawing.Point(161, 168);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(60, 40);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_del
            // 
            this.btn_del.ActiveControl = null;
            this.btn_del.Location = new System.Drawing.Point(91, 168);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(60, 40);
            this.btn_del.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_del.TabIndex = 15;
            this.btn_del.Text = "删除";
            this.btn_del.UseSelectable = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // mbtn_blacklist
            // 
            this.mbtn_blacklist.ActiveControl = null;
            this.mbtn_blacklist.Location = new System.Drawing.Point(21, 168);
            this.mbtn_blacklist.Name = "mbtn_blacklist";
            this.mbtn_blacklist.Size = new System.Drawing.Size(60, 40);
            this.mbtn_blacklist.Style = MetroFramework.MetroColorStyle.Black;
            this.mbtn_blacklist.TabIndex = 7;
            this.mbtn_blacklist.Text = "黑名单";
            this.mbtn_blacklist.UseSelectable = true;
            this.mbtn_blacklist.Click += new System.EventHandler(this.mbtn_blacklist_Click);
            // 
            // mbtn_import
            // 
            this.mbtn_import.ActiveControl = null;
            this.mbtn_import.Location = new System.Drawing.Point(21, 114);
            this.mbtn_import.Name = "mbtn_import";
            this.mbtn_import.Size = new System.Drawing.Size(60, 40);
            this.mbtn_import.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mbtn_import.TabIndex = 14;
            this.mbtn_import.Text = "导入";
            this.mbtn_import.UseSelectable = true;
            this.mbtn_import.Click += new System.EventHandler(this.mbtn_import_Click);
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView.Location = new System.Drawing.Point(237, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(189, 208);
            this.listView.TabIndex = 12;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // lbl_NO
            // 
            this.lbl_NO.AutoSize = true;
            this.lbl_NO.Location = new System.Drawing.Point(72, 40);
            this.lbl_NO.Name = "lbl_NO";
            this.lbl_NO.Size = new System.Drawing.Size(0, 0);
            this.lbl_NO.TabIndex = 11;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(72, 4);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 0);
            this.lbl_name.TabIndex = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "编号：";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "姓名：";
            // 
            // mbtn_get
            // 
            this.mbtn_get.ActiveControl = null;
            this.mbtn_get.Location = new System.Drawing.Point(161, 114);
            this.mbtn_get.Name = "mbtn_get";
            this.mbtn_get.Size = new System.Drawing.Size(60, 40);
            this.mbtn_get.TabIndex = 6;
            this.mbtn_get.Text = "查询";
            this.mbtn_get.UseSelectable = true;
            this.mbtn_get.Click += new System.EventHandler(this.mbtn_get_Click);
            // 
            // txb_select
            // 
            // 
            // 
            // 
            this.txb_select.CustomButton.Image = null;
            this.txb_select.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txb_select.CustomButton.Name = "";
            this.txb_select.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_select.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_select.CustomButton.TabIndex = 1;
            this.txb_select.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_select.CustomButton.UseSelectable = true;
            this.txb_select.CustomButton.Visible = false;
            this.txb_select.Lines = new string[0];
            this.txb_select.Location = new System.Drawing.Point(21, 72);
            this.txb_select.MaxLength = 32767;
            this.txb_select.Name = "txb_select";
            this.txb_select.PasswordChar = '\0';
            this.txb_select.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_select.SelectedText = "";
            this.txb_select.SelectionLength = 0;
            this.txb_select.SelectionStart = 0;
            this.txb_select.Size = new System.Drawing.Size(200, 23);
            this.txb_select.TabIndex = 5;
            this.txb_select.UseSelectable = true;
            this.txb_select.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_select.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mpbar
            // 
            this.mpbar.Location = new System.Drawing.Point(355, 36);
            this.mpbar.Name = "mpbar";
            this.mpbar.Size = new System.Drawing.Size(24, 23);
            this.mpbar.TabIndex = 13;
            // 
            // ParkStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 315);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.mpbar);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParkStudent";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "查询";
            this.Load += new System.EventHandler(this.ParkStudent_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbl_NO;
        private MetroFramework.Controls.MetroLabel lbl_name;
        private MetroFramework.Controls.MetroTile mbtn_blacklist;
        private MetroFramework.Controls.MetroTile mbtn_get;
        private MetroFramework.Controls.MetroTextBox txb_select;
        private MetroFramework.Controls.MetroProgressBar mpbar;
        private MetroFramework.Controls.MetroTile mbtn_import;
        private System.Windows.Forms.ListView listView;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btn_del;
        private MetroFramework.Controls.MetroTile btn_clear;
    }
}


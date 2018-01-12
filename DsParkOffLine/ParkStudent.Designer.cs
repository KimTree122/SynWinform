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
            this.lbl_NO = new MetroFramework.Controls.MetroLabel();
            this.lbl_name = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mbtn_load = new MetroFramework.Controls.MetroTile();
            this.mbtn_get = new MetroFramework.Controls.MetroTile();
            this.txb_select = new MetroFramework.Controls.MetroTextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.listView);
            this.metroPanel1.Controls.Add(this.lbl_NO);
            this.metroPanel1.Controls.Add(this.lbl_name);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.mbtn_load);
            this.metroPanel1.Controls.Add(this.mbtn_get);
            this.metroPanel1.Controls.Add(this.txb_select);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(27, 80);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(496, 193);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_NO
            // 
            this.lbl_NO.AutoSize = true;
            this.lbl_NO.Location = new System.Drawing.Point(98, 53);
            this.lbl_NO.Name = "lbl_NO";
            this.lbl_NO.Size = new System.Drawing.Size(0, 0);
            this.lbl_NO.TabIndex = 11;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(101, 17);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 0);
            this.lbl_name.TabIndex = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "编号：";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "姓名：";
            // 
            // mbtn_load
            // 
            this.mbtn_load.ActiveControl = null;
            this.mbtn_load.Location = new System.Drawing.Point(167, 125);
            this.mbtn_load.Name = "mbtn_load";
            this.mbtn_load.Size = new System.Drawing.Size(75, 48);
            this.mbtn_load.Style = MetroFramework.MetroColorStyle.Orange;
            this.mbtn_load.TabIndex = 7;
            this.mbtn_load.Text = "加载";
            this.mbtn_load.UseSelectable = true;
            this.mbtn_load.Click += new System.EventHandler(this.mbtn_load_Click);
            // 
            // mbtn_get
            // 
            this.mbtn_get.ActiveControl = null;
            this.mbtn_get.Location = new System.Drawing.Point(44, 125);
            this.mbtn_get.Name = "mbtn_get";
            this.mbtn_get.Size = new System.Drawing.Size(75, 48);
            this.mbtn_get.TabIndex = 6;
            this.mbtn_get.Text = "读取";
            this.mbtn_get.UseSelectable = true;
            this.mbtn_get.Click += new System.EventHandler(this.mbtn_get_Click);
            // 
            // txb_select
            // 
            // 
            // 
            // 
            this.txb_select.CustomButton.Image = null;
            this.txb_select.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txb_select.CustomButton.Name = "";
            this.txb_select.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_select.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_select.CustomButton.TabIndex = 1;
            this.txb_select.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_select.CustomButton.UseSelectable = true;
            this.txb_select.CustomButton.Visible = false;
            this.txb_select.Lines = new string[0];
            this.txb_select.Location = new System.Drawing.Point(44, 86);
            this.txb_select.MaxLength = 32767;
            this.txb_select.Name = "txb_select";
            this.txb_select.PasswordChar = '\0';
            this.txb_select.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_select.SelectedText = "";
            this.txb_select.SelectionLength = 0;
            this.txb_select.SelectionStart = 0;
            this.txb_select.Size = new System.Drawing.Size(198, 23);
            this.txb_select.TabIndex = 5;
            this.txb_select.UseSelectable = true;
            this.txb_select.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_select.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView.Location = new System.Drawing.Point(248, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(248, 193);
            this.listView.TabIndex = 12;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // ParkStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mbtn_load;
        private MetroFramework.Controls.MetroTile mbtn_get;
        private MetroFramework.Controls.MetroTextBox txb_select;
        private System.Windows.Forms.ListView listView;
    }
}


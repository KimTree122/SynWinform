namespace UpgradeFile
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.probar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxb = new System.Windows.Forms.RichTextBox();
            this.btn_upgrade = new MetroFramework.Controls.MetroTile();
            this.listView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // probar
            // 
            this.probar.Dock = System.Windows.Forms.DockStyle.Top;
            this.probar.Location = new System.Drawing.Point(27, 80);
            this.probar.Margin = new System.Windows.Forms.Padding(4);
            this.probar.Name = "probar";
            this.probar.Size = new System.Drawing.Size(396, 31);
            this.probar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxb);
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Controls.Add(this.btn_upgrade);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(27, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "明细说明";
            // 
            // rtxb
            // 
            this.rtxb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxb.Location = new System.Drawing.Point(153, 22);
            this.rtxb.Name = "rtxb";
            this.rtxb.Size = new System.Drawing.Size(190, 137);
            this.rtxb.TabIndex = 2;
            this.rtxb.Text = "";
            // 
            // btn_upgrade
            // 
            this.btn_upgrade.ActiveControl = null;
            this.btn_upgrade.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_upgrade.Location = new System.Drawing.Point(343, 22);
            this.btn_upgrade.Name = "btn_upgrade";
            this.btn_upgrade.Size = new System.Drawing.Size(50, 137);
            this.btn_upgrade.TabIndex = 3;
            this.btn_upgrade.Text = "升级";
            this.btn_upgrade.UseSelectable = true;
            this.btn_upgrade.Click += new System.EventHandler(this.btn_upgrade_Click);
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView.Location = new System.Drawing.Point(3, 22);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(150, 137);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.probar);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "升级";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar probar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxb;
        private MetroFramework.Controls.MetroTile btn_upgrade;
        private System.Windows.Forms.ListView listView;
    }
}


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
            this.btn_set = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mps
            // 
            this.mps.Location = new System.Drawing.Point(150, 83);
            this.mps.Maximum = 100;
            this.mps.Name = "mps";
            this.mps.Size = new System.Drawing.Size(200, 200);
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
            // 
            // btn_exist
            // 
            this.btn_exist.ActiveControl = null;
            this.btn_exist.Location = new System.Drawing.Point(387, 303);
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
            this.btn_download.Location = new System.Drawing.Point(163, 303);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(80, 50);
            this.btn_download.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_download.TabIndex = 3;
            this.btn_download.Text = "重新加载";
            this.btn_download.UseSelectable = true;
            // 
            // btn_set
            // 
            this.btn_set.ActiveControl = null;
            this.btn_set.Location = new System.Drawing.Point(275, 303);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(80, 50);
            this.btn_set.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_set.TabIndex = 4;
            this.btn_set.Text = "初始化";
            this.btn_set.UseSelectable = true;
            // 
            // CheckStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.mps);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckStudent";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "检查登记";
            this.Load += new System.EventHandler(this.CheckStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner mps;
        private MetroFramework.Controls.MetroTile btn_start;
        private MetroFramework.Controls.MetroTile btn_exist;
        private MetroFramework.Controls.MetroTile btn_download;
        private MetroFramework.Controls.MetroTile btn_set;
    }
}
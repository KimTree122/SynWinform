namespace CS.UI.WorkForm
{
    partial class FrmCheckInDTAdd
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
            this.Cmb_stauts = new MetroFramework.Controls.MetroComboBox();
            this.ratingStar = new DevComponents.DotNetBar.Controls.RatingStar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.rtxb_memo = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Btn_enter = new MetroFramework.Controls.MetroTile();
            this.Btn_cancel = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 148);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "状态";
            // 
            // Cmb_stauts
            // 
            this.Cmb_stauts.FormattingEnabled = true;
            this.Cmb_stauts.ItemHeight = 23;
            this.Cmb_stauts.Location = new System.Drawing.Point(109, 143);
            this.Cmb_stauts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_stauts.Name = "Cmb_stauts";
            this.Cmb_stauts.Size = new System.Drawing.Size(160, 29);
            this.Cmb_stauts.TabIndex = 1;
            this.Cmb_stauts.UseSelectable = true;
            // 
            // ratingStar
            // 
            // 
            // 
            // 
            this.ratingStar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ratingStar.Location = new System.Drawing.Point(109, 82);
            this.ratingStar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ratingStar.Name = "ratingStar";
            this.ratingStar.Size = new System.Drawing.Size(184, 31);
            this.ratingStar.TabIndex = 3;
            this.ratingStar.TextColor = System.Drawing.Color.Empty;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 209);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "备注";
            // 
            // rtxb_memo
            // 
            this.rtxb_memo.Location = new System.Drawing.Point(109, 209);
            this.rtxb_memo.Name = "rtxb_memo";
            this.rtxb_memo.Size = new System.Drawing.Size(160, 96);
            this.rtxb_memo.TabIndex = 5;
            this.rtxb_memo.Text = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 88);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "等级";
            // 
            // Btn_enter
            // 
            this.Btn_enter.ActiveControl = null;
            this.Btn_enter.Location = new System.Drawing.Point(189, 327);
            this.Btn_enter.Name = "Btn_enter";
            this.Btn_enter.Size = new System.Drawing.Size(80, 40);
            this.Btn_enter.TabIndex = 6;
            this.Btn_enter.Text = "确定";
            this.Btn_enter.UseSelectable = true;
            this.Btn_enter.Click += new System.EventHandler(this.Btn_enter_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.ActiveControl = null;
            this.Btn_cancel.Location = new System.Drawing.Point(37, 327);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(80, 40);
            this.Btn_cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.Btn_cancel.TabIndex = 7;
            this.Btn_cancel.Text = "取消";
            this.Btn_cancel.UseSelectable = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // FrmCheckInDTAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 406);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_enter);
            this.Controls.Add(this.rtxb_memo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ratingStar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Cmb_stauts);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCheckInDTAdd";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "添加明细";
            this.Load += new System.EventHandler(this.FrmCheckInDTAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox Cmb_stauts;
        private DevComponents.DotNetBar.Controls.RatingStar ratingStar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.RichTextBox rtxb_memo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile Btn_enter;
        private MetroFramework.Controls.MetroTile Btn_cancel;
    }
}
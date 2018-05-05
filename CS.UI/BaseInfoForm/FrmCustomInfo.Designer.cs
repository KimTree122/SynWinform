namespace CS.UI.BaseInfoForm
{
    partial class FrmCustomInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btn_add = new DevComponents.DotNetBar.ButtonItem();
            this.btn_edit = new DevComponents.DotNetBar.ButtonItem();
            this.btn_del = new DevComponents.DotNetBar.ButtonItem();
            this.split_con = new System.Windows.Forms.SplitContainer();
            this.btn_cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.txb_meno = new MetroFramework.Controls.MetroTextBox();
            this.txb_address = new MetroFramework.Controls.MetroTextBox();
            this.txb_tel = new MetroFramework.Controls.MetroTextBox();
            this.txb_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbl_address = new MetroFramework.Controls.MetroLabel();
            this.lbl_tel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgv = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.split_con)).BeginInit();
            this.split_con.Panel1.SuspendLayout();
            this.split_con.Panel2.SuspendLayout();
            this.split_con.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_add,
            this.btn_edit,
            this.btn_del});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(322, 83);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::CS.UI.Properties.Resources.add;
            this.btn_add.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_add.Name = "btn_add";
            this.btn_add.SubItemsExpandWidth = 14;
            this.btn_add.Text = "增加";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = global::CS.UI.Properties.Resources.Eidter;
            this.btn_edit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.SubItemsExpandWidth = 14;
            this.btn_edit.Text = "编辑";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Image = global::CS.UI.Properties.Resources.delete;
            this.btn_del.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_del.Name = "btn_del";
            this.btn_del.SubItemsExpandWidth = 14;
            this.btn_del.Text = "删除";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // split_con
            // 
            this.split_con.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_con.Location = new System.Drawing.Point(0, 83);
            this.split_con.Name = "split_con";
            // 
            // split_con.Panel1
            // 
            this.split_con.Panel1.Controls.Add(this.btn_cancel);
            this.split_con.Panel1.Controls.Add(this.btn_save);
            this.split_con.Panel1.Controls.Add(this.txb_meno);
            this.split_con.Panel1.Controls.Add(this.txb_address);
            this.split_con.Panel1.Controls.Add(this.txb_tel);
            this.split_con.Panel1.Controls.Add(this.txb_name);
            this.split_con.Panel1.Controls.Add(this.metroLabel4);
            this.split_con.Panel1.Controls.Add(this.lbl_address);
            this.split_con.Panel1.Controls.Add(this.lbl_tel);
            this.split_con.Panel1.Controls.Add(this.metroLabel1);
            this.split_con.Panel1Collapsed = true;
            // 
            // split_con.Panel2
            // 
            this.split_con.Panel2.Controls.Add(this.dgv);
            this.split_con.Size = new System.Drawing.Size(322, 148);
            this.split_con.SplitterDistance = 227;
            this.split_con.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancel.Image = global::CS.UI.Properties.Resources.forbid;
            this.btn_cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_cancel.Location = new System.Drawing.Point(144, 305);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(60, 60);
            this.btn_cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Image = global::CS.UI.Properties.Resources.save;
            this.btn_save.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_save.Location = new System.Drawing.Point(69, 305);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(60, 60);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "保存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txb_meno
            // 
            // 
            // 
            // 
            this.txb_meno.CustomButton.Image = null;
            this.txb_meno.CustomButton.Location = new System.Drawing.Point(37, 1);
            this.txb_meno.CustomButton.Name = "";
            this.txb_meno.CustomButton.Size = new System.Drawing.Size(97, 97);
            this.txb_meno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_meno.CustomButton.TabIndex = 1;
            this.txb_meno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_meno.CustomButton.UseSelectable = true;
            this.txb_meno.CustomButton.Visible = false;
            this.txb_meno.Lines = new string[0];
            this.txb_meno.Location = new System.Drawing.Point(69, 200);
            this.txb_meno.MaxLength = 32767;
            this.txb_meno.Multiline = true;
            this.txb_meno.Name = "txb_meno";
            this.txb_meno.PasswordChar = '\0';
            this.txb_meno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_meno.SelectedText = "";
            this.txb_meno.SelectionLength = 0;
            this.txb_meno.SelectionStart = 0;
            this.txb_meno.Size = new System.Drawing.Size(135, 99);
            this.txb_meno.TabIndex = 7;
            this.txb_meno.UseSelectable = true;
            this.txb_meno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_meno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_address
            // 
            // 
            // 
            // 
            this.txb_address.CustomButton.Image = null;
            this.txb_address.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txb_address.CustomButton.Name = "";
            this.txb_address.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_address.CustomButton.TabIndex = 1;
            this.txb_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_address.CustomButton.UseSelectable = true;
            this.txb_address.CustomButton.Visible = false;
            this.txb_address.Lines = new string[0];
            this.txb_address.Location = new System.Drawing.Point(69, 157);
            this.txb_address.MaxLength = 32767;
            this.txb_address.Name = "txb_address";
            this.txb_address.PasswordChar = '\0';
            this.txb_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_address.SelectedText = "";
            this.txb_address.SelectionLength = 0;
            this.txb_address.SelectionStart = 0;
            this.txb_address.Size = new System.Drawing.Size(135, 23);
            this.txb_address.TabIndex = 6;
            this.txb_address.UseSelectable = true;
            this.txb_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_tel
            // 
            // 
            // 
            // 
            this.txb_tel.CustomButton.Image = null;
            this.txb_tel.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txb_tel.CustomButton.Name = "";
            this.txb_tel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_tel.CustomButton.TabIndex = 1;
            this.txb_tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_tel.CustomButton.UseSelectable = true;
            this.txb_tel.CustomButton.Visible = false;
            this.txb_tel.Lines = new string[0];
            this.txb_tel.Location = new System.Drawing.Point(69, 114);
            this.txb_tel.MaxLength = 32767;
            this.txb_tel.Name = "txb_tel";
            this.txb_tel.PasswordChar = '\0';
            this.txb_tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_tel.SelectedText = "";
            this.txb_tel.SelectionLength = 0;
            this.txb_tel.SelectionStart = 0;
            this.txb_tel.Size = new System.Drawing.Size(135, 23);
            this.txb_tel.TabIndex = 5;
            this.txb_tel.UseSelectable = true;
            this.txb_tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_name
            // 
            // 
            // 
            // 
            this.txb_name.CustomButton.Image = null;
            this.txb_name.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txb_name.CustomButton.Name = "";
            this.txb_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_name.CustomButton.TabIndex = 1;
            this.txb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_name.CustomButton.UseSelectable = true;
            this.txb_name.CustomButton.Visible = false;
            this.txb_name.Lines = new string[0];
            this.txb_name.Location = new System.Drawing.Point(69, 71);
            this.txb_name.MaxLength = 32767;
            this.txb_name.Name = "txb_name";
            this.txb_name.PasswordChar = '\0';
            this.txb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_name.SelectedText = "";
            this.txb_name.SelectionLength = 0;
            this.txb_name.SelectionStart = 0;
            this.txb_name.Size = new System.Drawing.Size(135, 23);
            this.txb_name.TabIndex = 4;
            this.txb_name.UseSelectable = true;
            this.txb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 202);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "备注";
            this.metroLabel4.WrapToLine = true;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(12, 159);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(37, 19);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "地址";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(12, 116);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(37, 19);
            this.lbl_tel.TabIndex = 1;
            this.lbl_tel.Text = "电话";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "称呼";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(322, 148);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // FrmCustomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 231);
            this.Controls.Add(this.split_con);
            this.Controls.Add(this.ribbonBar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCustomInfo";
            this.Text = "FrmCustomInfo";
            this.Load += new System.EventHandler(this.FrmCustomInfo_Load);
            this.split_con.Panel1.ResumeLayout(false);
            this.split_con.Panel1.PerformLayout();
            this.split_con.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_con)).EndInit();
            this.split_con.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btn_add;
        private DevComponents.DotNetBar.ButtonItem btn_edit;
        private DevComponents.DotNetBar.ButtonItem btn_del;
        private System.Windows.Forms.SplitContainer split_con;
        private MetroFramework.Controls.MetroTextBox txb_meno;
        private MetroFramework.Controls.MetroTextBox txb_address;
        private MetroFramework.Controls.MetroTextBox txb_tel;
        private MetroFramework.Controls.MetroTextBox txb_name;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbl_address;
        private MetroFramework.Controls.MetroLabel lbl_tel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgv;
        private DevComponents.DotNetBar.ButtonX btn_cancel;
        private DevComponents.DotNetBar.ButtonX btn_save;
    }
}
﻿namespace CS.UI.WorkForm
{
    partial class FrmCheckServer
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
            this.panel_inorout = new DevComponents.DotNetBar.PanelEx();
            this.btn_find = new DevComponents.DotNetBar.ButtonX();
            this.txb_custom = new KControl.TextListBox();
            this.panel_in = new DevComponents.DotNetBar.PanelEx();
            this.panel_detail = new DevComponents.DotNetBar.PanelEx();
            this.txb_servertype = new MetroFramework.Controls.MetroTextBox();
            this.lbl_sertype = new System.Windows.Forms.LinkLabel();
            this.lbl_date = new System.Windows.Forms.LinkLabel();
            this.txb_predate = new MetroFramework.Controls.MetroTextBox();
            this.btn_print = new MetroFramework.Controls.MetroTile();
            this.lbl_detail = new System.Windows.Forms.LinkLabel();
            this.progressSteps = new DevComponents.DotNetBar.ProgressSteps();
            this.ratingStar = new DevComponents.DotNetBar.Controls.RatingStar();
            this.btn_creat = new MetroFramework.Controls.MetroTile();
            this.btn_back = new MetroFramework.Controls.MetroTile();
            this.lbl_qrcode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_qr = new System.Windows.Forms.PictureBox();
            this.rtxb_des = new System.Windows.Forms.RichTextBox();
            this.gb_cs = new System.Windows.Forms.GroupBox();
            this.Tree_cs = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ribbonBar = new DevComponents.DotNetBar.RibbonBar();
            this.btn_add = new DevComponents.DotNetBar.ButtonItem();
            this.btn_modi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_del = new DevComponents.DotNetBar.ButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_his = new System.Windows.Forms.GroupBox();
            this.dgv = new MetroFramework.Controls.MetroGrid();
            this.gb_custom = new System.Windows.Forms.GroupBox();
            this.btn_enter = new MetroFramework.Controls.MetroTile();
            this.btn_cancel = new MetroFramework.Controls.MetroTile();
            this.txb_tel = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_name = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plan_back = new DevComponents.DotNetBar.PanelEx();
            this.panel_out = new DevComponents.DotNetBar.PanelEx();
            this.panel_inorout.SuspendLayout();
            this.panel_in.SuspendLayout();
            this.panel_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).BeginInit();
            this.gb_cs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tree_cs)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb_his.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gb_custom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_inorout
            // 
            this.panel_inorout.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_inorout.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_inorout.Controls.Add(this.btn_find);
            this.panel_inorout.Controls.Add(this.txb_custom);
            this.panel_inorout.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_inorout.Location = new System.Drawing.Point(38, 179);
            this.panel_inorout.Name = "panel_inorout";
            this.panel_inorout.Size = new System.Drawing.Size(482, 181);
            this.panel_inorout.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_inorout.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_inorout.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_inorout.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_inorout.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_inorout.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_inorout.Style.GradientAngle = 90;
            this.panel_inorout.TabIndex = 0;
            // 
            // btn_find
            // 
            this.btn_find.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_find.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_find.Location = new System.Drawing.Point(324, 75);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(0, 50);
            this.btn_find.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "查询";
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txb_custom
            // 
            this.txb_custom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_custom.Font = new System.Drawing.Font("宋体", 15F);
            this.txb_custom.Location = new System.Drawing.Point(257, -11);
            this.txb_custom.Name = "txb_custom";
            this.txb_custom.Size = new System.Drawing.Size(133, 30);
            this.txb_custom.TabIndex = 0;
            this.txb_custom.Tag = 0;
            // 
            // panel_in
            // 
            this.panel_in.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_in.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_in.Controls.Add(this.panel_detail);
            this.panel_in.Controls.Add(this.gb_cs);
            this.panel_in.Controls.Add(this.ribbonBar);
            this.panel_in.Controls.Add(this.panel1);
            this.panel_in.Controls.Add(this.plan_back);
            this.panel_in.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_in.Location = new System.Drawing.Point(0, 0);
            this.panel_in.Name = "panel_in";
            this.panel_in.Size = new System.Drawing.Size(849, 578);
            this.panel_in.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_in.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_in.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_in.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_in.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_in.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_in.Style.GradientAngle = 90;
            this.panel_in.TabIndex = 7;
            // 
            // panel_detail
            // 
            this.panel_detail.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_detail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_detail.Controls.Add(this.txb_servertype);
            this.panel_detail.Controls.Add(this.lbl_sertype);
            this.panel_detail.Controls.Add(this.lbl_date);
            this.panel_detail.Controls.Add(this.txb_predate);
            this.panel_detail.Controls.Add(this.btn_print);
            this.panel_detail.Controls.Add(this.lbl_detail);
            this.panel_detail.Controls.Add(this.progressSteps);
            this.panel_detail.Controls.Add(this.ratingStar);
            this.panel_detail.Controls.Add(this.btn_creat);
            this.panel_detail.Controls.Add(this.btn_back);
            this.panel_detail.Controls.Add(this.lbl_qrcode);
            this.panel_detail.Controls.Add(this.label4);
            this.panel_detail.Controls.Add(this.pb_qr);
            this.panel_detail.Controls.Add(this.rtxb_des);
            this.panel_detail.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_detail.Location = new System.Drawing.Point(362, 65);
            this.panel_detail.Name = "panel_detail";
            this.panel_detail.Size = new System.Drawing.Size(399, 513);
            this.panel_detail.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_detail.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_detail.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_detail.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_detail.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_detail.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_detail.Style.GradientAngle = 90;
            this.panel_detail.TabIndex = 3;
            // 
            // txb_servertype
            // 
            this.txb_servertype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txb_servertype.CustomButton.Image = null;
            this.txb_servertype.CustomButton.Location = new System.Drawing.Point(377, 1);
            this.txb_servertype.CustomButton.Name = "";
            this.txb_servertype.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_servertype.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_servertype.CustomButton.TabIndex = 1;
            this.txb_servertype.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_servertype.CustomButton.UseSelectable = true;
            this.txb_servertype.CustomButton.Visible = false;
            this.txb_servertype.Enabled = false;
            this.txb_servertype.Lines = new string[0];
            this.txb_servertype.Location = new System.Drawing.Point(101, 94);
            this.txb_servertype.MaxLength = 32767;
            this.txb_servertype.Name = "txb_servertype";
            this.txb_servertype.PasswordChar = '\0';
            this.txb_servertype.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_servertype.SelectedText = "";
            this.txb_servertype.SelectionLength = 0;
            this.txb_servertype.SelectionStart = 0;
            this.txb_servertype.Size = new System.Drawing.Size(399, 23);
            this.txb_servertype.TabIndex = 15;
            this.txb_servertype.UseSelectable = true;
            this.txb_servertype.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_servertype.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_sertype
            // 
            this.lbl_sertype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sertype.AutoSize = true;
            this.lbl_sertype.Location = new System.Drawing.Point(23, 97);
            this.lbl_sertype.Name = "lbl_sertype";
            this.lbl_sertype.Size = new System.Drawing.Size(72, 16);
            this.lbl_sertype.TabIndex = 14;
            this.lbl_sertype.TabStop = true;
            this.lbl_sertype.Text = "服务类别";
            this.lbl_sertype.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_sertype_LinkClicked);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(150, 249);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(72, 16);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.TabStop = true;
            this.lbl_date.Text = "预计日期";
            // 
            // txb_predate
            // 
            // 
            // 
            // 
            this.txb_predate.CustomButton.Image = null;
            this.txb_predate.CustomButton.Location = new System.Drawing.Point(377, 1);
            this.txb_predate.CustomButton.Name = "";
            this.txb_predate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_predate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_predate.CustomButton.TabIndex = 1;
            this.txb_predate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_predate.CustomButton.UseSelectable = true;
            this.txb_predate.CustomButton.Visible = false;
            this.txb_predate.Lines = new string[0];
            this.txb_predate.Location = new System.Drawing.Point(153, 280);
            this.txb_predate.MaxLength = 32767;
            this.txb_predate.Name = "txb_predate";
            this.txb_predate.PasswordChar = '\0';
            this.txb_predate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_predate.SelectedText = "";
            this.txb_predate.SelectionLength = 0;
            this.txb_predate.SelectionStart = 0;
            this.txb_predate.Size = new System.Drawing.Size(399, 23);
            this.txb_predate.TabIndex = 12;
            this.txb_predate.UseSelectable = true;
            this.txb_predate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_predate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_print
            // 
            this.btn_print.ActiveControl = null;
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_print.Location = new System.Drawing.Point(23, 443);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(120, 45);
            this.btn_print.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btn_print.TabIndex = 10;
            this.btn_print.Text = "打印";
            this.btn_print.UseSelectable = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lbl_detail
            // 
            this.lbl_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_detail.AutoSize = true;
            this.lbl_detail.Location = new System.Drawing.Point(23, 136);
            this.lbl_detail.Name = "lbl_detail";
            this.lbl_detail.Size = new System.Drawing.Size(72, 16);
            this.lbl_detail.TabIndex = 9;
            this.lbl_detail.TabStop = true;
            this.lbl_detail.Text = "服务描述";
            // 
            // progressSteps
            // 
            // 
            // 
            // 
            this.progressSteps.BackgroundStyle.Class = "ProgressSteps";
            this.progressSteps.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressSteps.ContainerControlProcessDialogKey = true;
            this.progressSteps.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressSteps.Location = new System.Drawing.Point(0, 0);
            this.progressSteps.Name = "progressSteps";
            this.progressSteps.Size = new System.Drawing.Size(399, 23);
            this.progressSteps.TabIndex = 8;
            // 
            // ratingStar
            // 
            this.ratingStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ratingStar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ratingStar.Location = new System.Drawing.Point(100, 133);
            this.ratingStar.Name = "ratingStar";
            this.ratingStar.Size = new System.Drawing.Size(399, 23);
            this.ratingStar.TabIndex = 7;
            this.ratingStar.Text = "紧急程度";
            this.ratingStar.TextColor = System.Drawing.Color.Empty;
            // 
            // btn_creat
            // 
            this.btn_creat.ActiveControl = null;
            this.btn_creat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_creat.Location = new System.Drawing.Point(329, 443);
            this.btn_creat.Name = "btn_creat";
            this.btn_creat.Size = new System.Drawing.Size(120, 45);
            this.btn_creat.TabIndex = 6;
            this.btn_creat.Text = "确定";
            this.btn_creat.UseSelectable = true;
            this.btn_creat.Click += new System.EventHandler(this.btn_creat_Click);
            // 
            // btn_back
            // 
            this.btn_back.ActiveControl = null;
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.Location = new System.Drawing.Point(172, 443);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 45);
            this.btn_back.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "取消";
            this.btn_back.UseSelectable = true;
            // 
            // lbl_qrcode
            // 
            this.lbl_qrcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_qrcode.AutoSize = true;
            this.lbl_qrcode.Location = new System.Drawing.Point(23, 424);
            this.lbl_qrcode.Name = "lbl_qrcode";
            this.lbl_qrcode.Size = new System.Drawing.Size(0, 16);
            this.lbl_qrcode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "二维码";
            // 
            // pb_qr
            // 
            this.pb_qr.Location = new System.Drawing.Point(23, 280);
            this.pb_qr.Name = "pb_qr";
            this.pb_qr.Size = new System.Drawing.Size(120, 120);
            this.pb_qr.TabIndex = 2;
            this.pb_qr.TabStop = false;
            // 
            // rtxb_des
            // 
            this.rtxb_des.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxb_des.Location = new System.Drawing.Point(23, 162);
            this.rtxb_des.Name = "rtxb_des";
            this.rtxb_des.Size = new System.Drawing.Size(399, 70);
            this.rtxb_des.TabIndex = 1;
            this.rtxb_des.Text = "";
            // 
            // gb_cs
            // 
            this.gb_cs.Controls.Add(this.Tree_cs);
            this.gb_cs.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_cs.Location = new System.Drawing.Point(200, 65);
            this.gb_cs.Name = "gb_cs";
            this.gb_cs.Size = new System.Drawing.Size(162, 513);
            this.gb_cs.TabIndex = 1;
            this.gb_cs.TabStop = false;
            this.gb_cs.Text = "服务内容";
            // 
            // Tree_cs
            // 
            this.Tree_cs.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.Tree_cs.AllowDrop = true;
            this.Tree_cs.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.Tree_cs.BackgroundStyle.Class = "TreeBorderKey";
            this.Tree_cs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Tree_cs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree_cs.Location = new System.Drawing.Point(3, 22);
            this.Tree_cs.Name = "Tree_cs";
            this.Tree_cs.NodesConnector = this.nodeConnector1;
            this.Tree_cs.NodeStyle = this.elementStyle1;
            this.Tree_cs.PathSeparator = ";";
            this.Tree_cs.Size = new System.Drawing.Size(156, 488);
            this.Tree_cs.Styles.Add(this.elementStyle1);
            this.Tree_cs.TabIndex = 0;
            this.Tree_cs.Text = "advTree1";
            this.Tree_cs.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.Tree_cs_AfterNodeSelect);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // ribbonBar
            // 
            this.ribbonBar.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar.ContainerControlProcessDialogKey = true;
            this.ribbonBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar.DragDropSupport = true;
            this.ribbonBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_add,
            this.btn_modi,
            this.btn_del});
            this.ribbonBar.Location = new System.Drawing.Point(200, 0);
            this.ribbonBar.Name = "ribbonBar";
            this.ribbonBar.Size = new System.Drawing.Size(561, 65);
            this.ribbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar.TabIndex = 2;
            // 
            // 
            // 
            this.ribbonBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btn_add
            // 
            this.btn_add.Name = "btn_add";
            this.btn_add.SubItemsExpandWidth = 14;
            this.btn_add.Text = "新增";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modi
            // 
            this.btn_modi.Name = "btn_modi";
            this.btn_modi.SubItemsExpandWidth = 14;
            this.btn_modi.Text = "编辑";
            this.btn_modi.Click += new System.EventHandler(this.btn_modi_Click);
            // 
            // btn_del
            // 
            this.btn_del.Name = "btn_del";
            this.btn_del.SubItemsExpandWidth = 14;
            this.btn_del.Text = "删除";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gb_his);
            this.panel1.Controls.Add(this.gb_custom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 578);
            this.panel1.TabIndex = 0;
            // 
            // gb_his
            // 
            this.gb_his.Controls.Add(this.dgv);
            this.gb_his.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_his.Location = new System.Drawing.Point(0, 200);
            this.gb_his.Name = "gb_his";
            this.gb_his.Size = new System.Drawing.Size(200, 378);
            this.gb_his.TabIndex = 1;
            this.gb_his.TabStop = false;
            this.gb_his.Text = "维护历史";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.dgv.Location = new System.Drawing.Point(3, 22);
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
            this.dgv.Size = new System.Drawing.Size(194, 353);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // gb_custom
            // 
            this.gb_custom.Controls.Add(this.btn_enter);
            this.gb_custom.Controls.Add(this.btn_cancel);
            this.gb_custom.Controls.Add(this.txb_tel);
            this.gb_custom.Controls.Add(this.label2);
            this.gb_custom.Controls.Add(this.txb_name);
            this.gb_custom.Controls.Add(this.label1);
            this.gb_custom.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_custom.Location = new System.Drawing.Point(0, 0);
            this.gb_custom.Name = "gb_custom";
            this.gb_custom.Size = new System.Drawing.Size(200, 200);
            this.gb_custom.TabIndex = 0;
            this.gb_custom.TabStop = false;
            this.gb_custom.Text = "客户信息";
            // 
            // btn_enter
            // 
            this.btn_enter.ActiveControl = null;
            this.btn_enter.Location = new System.Drawing.Point(107, 144);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 35);
            this.btn_enter.TabIndex = 5;
            this.btn_enter.Text = "确定";
            this.btn_enter.UseSelectable = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveControl = null;
            this.btn_cancel.Location = new System.Drawing.Point(15, 144);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseSelectable = true;
            // 
            // txb_tel
            // 
            // 
            // 
            // 
            this.txb_tel.CustomButton.Image = null;
            this.txb_tel.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txb_tel.CustomButton.Name = "";
            this.txb_tel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_tel.CustomButton.TabIndex = 1;
            this.txb_tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_tel.CustomButton.UseSelectable = true;
            this.txb_tel.CustomButton.Visible = false;
            this.txb_tel.Lines = new string[0];
            this.txb_tel.Location = new System.Drawing.Point(86, 85);
            this.txb_tel.MaxLength = 32767;
            this.txb_tel.Name = "txb_tel";
            this.txb_tel.PasswordChar = '\0';
            this.txb_tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_tel.SelectedText = "";
            this.txb_tel.SelectionLength = 0;
            this.txb_tel.SelectionStart = 0;
            this.txb_tel.Size = new System.Drawing.Size(96, 23);
            this.txb_tel.TabIndex = 3;
            this.txb_tel.UseSelectable = true;
            this.txb_tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "联系电话";
            // 
            // txb_name
            // 
            // 
            // 
            // 
            this.txb_name.CustomButton.Image = null;
            this.txb_name.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txb_name.CustomButton.Name = "";
            this.txb_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_name.CustomButton.TabIndex = 1;
            this.txb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_name.CustomButton.UseSelectable = true;
            this.txb_name.CustomButton.Visible = false;
            this.txb_name.Lines = new string[0];
            this.txb_name.Location = new System.Drawing.Point(86, 34);
            this.txb_name.MaxLength = 32767;
            this.txb_name.Name = "txb_name";
            this.txb_name.PasswordChar = '\0';
            this.txb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_name.SelectedText = "";
            this.txb_name.SelectionLength = 0;
            this.txb_name.SelectionStart = 0;
            this.txb_name.Size = new System.Drawing.Size(96, 23);
            this.txb_name.TabIndex = 1;
            this.txb_name.UseSelectable = true;
            this.txb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "称呼";
            // 
            // plan_back
            // 
            this.plan_back.CanvasColor = System.Drawing.SystemColors.Control;
            this.plan_back.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.plan_back.DisabledBackColor = System.Drawing.Color.Empty;
            this.plan_back.Dock = System.Windows.Forms.DockStyle.Right;
            this.plan_back.Location = new System.Drawing.Point(761, 0);
            this.plan_back.Name = "plan_back";
            this.plan_back.Size = new System.Drawing.Size(88, 578);
            this.plan_back.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.plan_back.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.plan_back.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.plan_back.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.plan_back.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.plan_back.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.plan_back.Style.GradientAngle = 90;
            this.plan_back.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.plan_back.StyleMouseDown.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.plan_back.StyleMouseDown.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.plan_back.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.plan_back.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            this.plan_back.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.plan_back.StyleMouseOver.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground;
            this.plan_back.StyleMouseOver.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2;
            this.plan_back.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.plan_back.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.plan_back.TabIndex = 14;
            this.plan_back.Text = "返回";
            this.plan_back.Click += new System.EventHandler(this.plan_back_Click);
            // 
            // panel_out
            // 
            this.panel_out.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_out.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_out.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_out.Location = new System.Drawing.Point(230, 85);
            this.panel_out.Name = "panel_out";
            this.panel_out.Size = new System.Drawing.Size(96, 76);
            this.panel_out.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_out.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_out.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_out.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_out.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_out.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_out.Style.GradientAngle = 90;
            this.panel_out.TabIndex = 11;
            this.panel_out.Text = "OUT";
            // 
            // FrmCheckServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 578);
            this.Controls.Add(this.panel_in);
            this.Controls.Add(this.panel_inorout);
            this.Controls.Add(this.panel_out);
            this.DoubleBuffered = true;
            this.Name = "FrmCheckServer";
            this.Text = "FrmCheckServer";
            this.Load += new System.EventHandler(this.FrmCheckServer_Load);
            this.panel_inorout.ResumeLayout(false);
            this.panel_inorout.PerformLayout();
            this.panel_in.ResumeLayout(false);
            this.panel_detail.ResumeLayout(false);
            this.panel_detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).EndInit();
            this.gb_cs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tree_cs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gb_his.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gb_custom.ResumeLayout(false);
            this.gb_custom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panel_inorout;
        private DevComponents.DotNetBar.PanelEx panel_in;
        private DevComponents.DotNetBar.PanelEx panel_out;
        private KControl.TextListBox txb_custom;
        private DevComponents.DotNetBar.ButtonX btn_find;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_his;
        private System.Windows.Forms.GroupBox gb_custom;
        private System.Windows.Forms.GroupBox gb_cs;
        private DevComponents.AdvTree.AdvTree Tree_cs;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.PanelEx panel_detail;
        private DevComponents.DotNetBar.ProgressSteps progressSteps;
        private DevComponents.DotNetBar.Controls.RatingStar ratingStar;
        private MetroFramework.Controls.MetroTile btn_creat;
        private MetroFramework.Controls.MetroTile btn_back;
        private System.Windows.Forms.Label lbl_qrcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_qr;
        private System.Windows.Forms.RichTextBox rtxb_des;
        private DevComponents.DotNetBar.RibbonBar ribbonBar;
        private DevComponents.DotNetBar.ButtonItem btn_add;
        private DevComponents.DotNetBar.ButtonItem btn_modi;
        private DevComponents.DotNetBar.ButtonItem btn_del;
        private MetroFramework.Controls.MetroGrid dgv;
        private MetroFramework.Controls.MetroTile btn_enter;
        private MetroFramework.Controls.MetroTile btn_cancel;
        private MetroFramework.Controls.MetroTextBox txb_tel;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txb_name;
        private System.Windows.Forms.LinkLabel lbl_detail;
        private System.Windows.Forms.LinkLabel lbl_date;
        private MetroFramework.Controls.MetroTextBox txb_predate;
        private MetroFramework.Controls.MetroTile btn_print;
        private DevComponents.DotNetBar.PanelEx plan_back;
        private MetroFramework.Controls.MetroTextBox txb_servertype;
        private System.Windows.Forms.LinkLabel lbl_sertype;
    }
}
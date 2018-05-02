namespace CS.UI.BaseInfoForm
{
    partial class FrmUserInfo
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
            DevComponents.DotNetBar.StyleManager stylem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btn_find = new DevComponents.DotNetBar.ButtonItem();
            this.btn_add = new DevComponents.DotNetBar.ButtonItem();
            this.btn_edit = new DevComponents.DotNetBar.ButtonItem();
            this.btn_enter = new DevComponents.DotNetBar.ButtonItem();
            this.btn_cancel = new DevComponents.DotNetBar.ButtonItem();
            this.btn_visiable = new DevComponents.DotNetBar.ButtonItem();
            this.btn_del = new DevComponents.DotNetBar.ButtonItem();
            this.rti_oper = new DevComponents.DotNetBar.RibbonTabItem();
            this.dgv = new MetroFramework.Controls.MetroGrid();
            this.split_Con = new System.Windows.Forms.SplitContainer();
            this.gp = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmb_post = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_tel = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_name = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            stylem = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split_Con)).BeginInit();
            this.split_Con.Panel1.SuspendLayout();
            this.split_Con.Panel2.SuspendLayout();
            this.split_Con.SuspendLayout();
            this.gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // stylem
            // 
            stylem.ManagerColorTint = System.Drawing.Color.Silver;
            stylem.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            stylem.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rti_oper});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.Size = new System.Drawing.Size(468, 122);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 31);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(468, 88);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
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
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_find,
            this.btn_add,
            this.btn_edit,
            this.btn_enter,
            this.btn_cancel,
            this.btn_visiable,
            this.btn_del});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(462, 85);
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
            // btn_find
            // 
            this.btn_find.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btn_find.Image = global::CS.UI.Properties.Resources.Find;
            this.btn_find.ImagePaddingHorizontal = 10;
            this.btn_find.ImagePaddingVertical = 10;
            this.btn_find.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_find.Name = "btn_find";
            this.btn_find.SubItemsExpandWidth = 14;
            this.btn_find.Text = "查询";
            this.btn_find.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImagePaddingHorizontal = 10;
            this.btn_add.ImagePaddingVertical = 10;
            this.btn_add.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_add.Name = "btn_add";
            this.btn_add.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btn_add.SubItemsExpandWidth = 14;
            this.btn_add.Text = "新增";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btn_edit.Image = global::CS.UI.Properties.Resources.Eidter;
            this.btn_edit.ImagePaddingHorizontal = 10;
            this.btn_edit.ImagePaddingVertical = 10;
            this.btn_edit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.SubItemsExpandWidth = 14;
            this.btn_edit.Text = "编辑";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Enabled = false;
            this.btn_enter.Image = global::CS.UI.Properties.Resources.save;
            this.btn_enter.ImagePaddingHorizontal = 10;
            this.btn_enter.ImagePaddingVertical = 10;
            this.btn_enter.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.SubItemsExpandWidth = 14;
            this.btn_enter.Text = "确定";
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::CS.UI.Properties.Resources.forbid;
            this.btn_cancel.ImagePaddingHorizontal = 10;
            this.btn_cancel.ImagePaddingVertical = 10;
            this.btn_cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.SubItemsExpandWidth = 14;
            this.btn_cancel.Text = "返回";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_visiable
            // 
            this.btn_visiable.Image = ((System.Drawing.Image)(resources.GetObject("btn_visiable.Image")));
            this.btn_visiable.ImagePaddingHorizontal = 10;
            this.btn_visiable.ImagePaddingVertical = 10;
            this.btn_visiable.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_visiable.Name = "btn_visiable";
            this.btn_visiable.SubItemsExpandWidth = 14;
            this.btn_visiable.Text = "明细";
            this.btn_visiable.Click += new System.EventHandler(this.btn_visiable_Click);
            // 
            // btn_del
            // 
            this.btn_del.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_del.Image = global::CS.UI.Properties.Resources.delete;
            this.btn_del.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_del.Name = "btn_del";
            this.btn_del.SubItemsExpandWidth = 14;
            this.btn_del.Text = "删除";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // rti_oper
            // 
            this.rti_oper.Checked = true;
            this.rti_oper.Name = "rti_oper";
            this.rti_oper.Panel = this.ribbonPanel1;
            this.rti_oper.Text = "数据编辑";
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
            this.dgv.Size = new System.Drawing.Size(468, 301);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // split_Con
            // 
            this.split_Con.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_Con.Location = new System.Drawing.Point(0, 122);
            this.split_Con.Name = "split_Con";
            // 
            // split_Con.Panel1
            // 
            this.split_Con.Panel1.Controls.Add(this.gp);
            this.split_Con.Panel1Collapsed = true;
            // 
            // split_Con.Panel2
            // 
            this.split_Con.Panel2.Controls.Add(this.dgv);
            this.split_Con.Size = new System.Drawing.Size(468, 301);
            this.split_Con.SplitterDistance = 250;
            this.split_Con.TabIndex = 3;
            // 
            // gp
            // 
            this.gp.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp.Controls.Add(this.cmb_post);
            this.gp.Controls.Add(this.label3);
            this.gp.Controls.Add(this.txb_tel);
            this.gp.Controls.Add(this.label2);
            this.gp.Controls.Add(this.txb_name);
            this.gp.Controls.Add(this.label1);
            this.gp.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp.Enabled = false;
            this.gp.Location = new System.Drawing.Point(0, 0);
            this.gp.Name = "gp";
            this.gp.Size = new System.Drawing.Size(250, 301);
            // 
            // 
            // 
            this.gp.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp.Style.BackColorGradientAngle = 90;
            this.gp.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp.Style.BorderBottomWidth = 1;
            this.gp.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp.Style.BorderLeftWidth = 1;
            this.gp.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp.Style.BorderRightWidth = 1;
            this.gp.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp.Style.BorderTopWidth = 1;
            this.gp.Style.CornerDiameter = 4;
            this.gp.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp.TabIndex = 12;
            this.gp.Text = "编辑";
            // 
            // cmb_post
            // 
            this.cmb_post.FormattingEnabled = true;
            this.cmb_post.ItemHeight = 23;
            this.cmb_post.Location = new System.Drawing.Point(100, 172);
            this.cmb_post.Name = "cmb_post";
            this.cmb_post.Size = new System.Drawing.Size(121, 29);
            this.cmb_post.TabIndex = 17;
            this.cmb_post.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "职位";
            // 
            // txb_tel
            // 
            // 
            // 
            // 
            this.txb_tel.CustomButton.Image = null;
            this.txb_tel.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txb_tel.CustomButton.Name = "";
            this.txb_tel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_tel.CustomButton.TabIndex = 1;
            this.txb_tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_tel.CustomButton.UseSelectable = true;
            this.txb_tel.CustomButton.Visible = false;
            this.txb_tel.Lines = new string[0];
            this.txb_tel.Location = new System.Drawing.Point(100, 123);
            this.txb_tel.MaxLength = 32767;
            this.txb_tel.Name = "txb_tel";
            this.txb_tel.PasswordChar = '\0';
            this.txb_tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_tel.SelectedText = "";
            this.txb_tel.SelectionLength = 0;
            this.txb_tel.SelectionStart = 0;
            this.txb_tel.Size = new System.Drawing.Size(121, 23);
            this.txb_tel.TabIndex = 15;
            this.txb_tel.UseSelectable = true;
            this.txb_tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "电话";
            // 
            // txb_name
            // 
            // 
            // 
            // 
            this.txb_name.CustomButton.Image = null;
            this.txb_name.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txb_name.CustomButton.Name = "";
            this.txb_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_name.CustomButton.TabIndex = 1;
            this.txb_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_name.CustomButton.UseSelectable = true;
            this.txb_name.CustomButton.Visible = false;
            this.txb_name.Lines = new string[0];
            this.txb_name.Location = new System.Drawing.Point(100, 74);
            this.txb_name.MaxLength = 32767;
            this.txb_name.Name = "txb_name";
            this.txb_name.PasswordChar = '\0';
            this.txb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_name.SelectedText = "";
            this.txb_name.SelectionLength = 0;
            this.txb_name.SelectionStart = 0;
            this.txb_name.Size = new System.Drawing.Size(121, 23);
            this.txb_name.TabIndex = 13;
            this.txb_name.UseSelectable = true;
            this.txb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "姓名";
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 423);
            this.Controls.Add(this.split_Con);
            this.Controls.Add(this.ribbonControl1);
            this.DoubleBuffered = true;
            this.Name = "FrmUserInfo";
            this.Text = "FrmUserInfo";
            this.Load += new System.EventHandler(this.FrmUserInfo_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.split_Con.Panel1.ResumeLayout(false);
            this.split_Con.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_Con)).EndInit();
            this.split_Con.ResumeLayout(false);
            this.gp.ResumeLayout(false);
            this.gp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonTabItem rti_oper;
        private DevComponents.DotNetBar.ButtonItem btn_add;
        private DevComponents.DotNetBar.ButtonItem btn_find;
        private DevComponents.DotNetBar.ButtonItem btn_edit;
        private DevComponents.DotNetBar.ButtonItem btn_del;
        private MetroFramework.Controls.MetroGrid dgv;
        private DevComponents.DotNetBar.ButtonItem btn_enter;
        private DevComponents.DotNetBar.ButtonItem btn_cancel;
        private DevComponents.DotNetBar.ButtonItem btn_visiable;
        private System.Windows.Forms.SplitContainer split_Con;
        private DevComponents.DotNetBar.Controls.GroupPanel gp;
        private MetroFramework.Controls.MetroComboBox cmb_post;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txb_tel;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txb_name;
        private System.Windows.Forms.Label label1;
    }
}
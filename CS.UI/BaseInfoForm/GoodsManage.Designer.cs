namespace CS.UI.BaseInfoForm
{
    partial class GoodsManage
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.advTree = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btn_type_add = new DevComponents.DotNetBar.ButtonItem();
            this.btn_type_edit = new DevComponents.DotNetBar.ButtonItem();
            this.btn_type_del = new DevComponents.DotNetBar.ButtonItem();
            this.gp_deltail = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_top = new MetroFramework.Controls.MetroLabel();
            this.btn_cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.cmb_type = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txb_order = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txb_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txb_meno = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).BeginInit();
            this.gp_deltail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.advTree);
            this.groupPanel1.Controls.Add(this.ribbonBar1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(250, 404);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "服务类型";
            // 
            // advTree
            // 
            this.advTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree.AllowDrop = true;
            this.advTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advTree.Location = new System.Drawing.Point(0, 60);
            this.advTree.Name = "advTree";
            this.advTree.NodesConnector = this.nodeConnector1;
            this.advTree.NodeStyle = this.elementStyle1;
            this.advTree.PathSeparator = ";";
            this.advTree.Size = new System.Drawing.Size(244, 315);
            this.advTree.Styles.Add(this.elementStyle1);
            this.advTree.TabIndex = 1;
            this.advTree.Text = "advTree1";
            this.advTree.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.advTree_AfterNodeSelect);
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
            this.btn_type_add,
            this.btn_type_edit,
            this.btn_type_del});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(244, 60);
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
            // btn_type_add
            // 
            this.btn_type_add.Image = global::CS.UI.Properties.Resources.add;
            this.btn_type_add.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_type_add.Name = "btn_type_add";
            this.btn_type_add.SubItemsExpandWidth = 14;
            this.btn_type_add.Text = "增加";
            this.btn_type_add.Click += new System.EventHandler(this.btn_type_add_Click);
            // 
            // btn_type_edit
            // 
            this.btn_type_edit.Image = global::CS.UI.Properties.Resources.Eidter;
            this.btn_type_edit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_type_edit.Name = "btn_type_edit";
            this.btn_type_edit.SubItemsExpandWidth = 14;
            this.btn_type_edit.Text = "编辑";
            this.btn_type_edit.Click += new System.EventHandler(this.btn_type_edit_Click);
            // 
            // btn_type_del
            // 
            this.btn_type_del.Image = global::CS.UI.Properties.Resources.delete;
            this.btn_type_del.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_type_del.Name = "btn_type_del";
            this.btn_type_del.SubItemsExpandWidth = 14;
            this.btn_type_del.Text = "删除";
            this.btn_type_del.Click += new System.EventHandler(this.btn_type_del_Click);
            // 
            // gp_deltail
            // 
            this.gp_deltail.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_deltail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_deltail.Controls.Add(this.txb_meno);
            this.gp_deltail.Controls.Add(this.metroLabel4);
            this.gp_deltail.Controls.Add(this.lbl_top);
            this.gp_deltail.Controls.Add(this.btn_cancel);
            this.gp_deltail.Controls.Add(this.btn_save);
            this.gp_deltail.Controls.Add(this.cmb_type);
            this.gp_deltail.Controls.Add(this.metroLabel3);
            this.gp_deltail.Controls.Add(this.txb_order);
            this.gp_deltail.Controls.Add(this.metroLabel2);
            this.gp_deltail.Controls.Add(this.txb_name);
            this.gp_deltail.Controls.Add(this.metroLabel1);
            this.gp_deltail.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp_deltail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp_deltail.Enabled = false;
            this.gp_deltail.Location = new System.Drawing.Point(250, 0);
            this.gp_deltail.Name = "gp_deltail";
            this.gp_deltail.Size = new System.Drawing.Size(258, 404);
            // 
            // 
            // 
            this.gp_deltail.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_deltail.Style.BackColorGradientAngle = 90;
            this.gp_deltail.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_deltail.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_deltail.Style.BorderBottomWidth = 1;
            this.gp_deltail.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_deltail.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_deltail.Style.BorderLeftWidth = 1;
            this.gp_deltail.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_deltail.Style.BorderRightWidth = 1;
            this.gp_deltail.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_deltail.Style.BorderTopWidth = 1;
            this.gp_deltail.Style.CornerDiameter = 4;
            this.gp_deltail.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_deltail.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_deltail.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_deltail.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_deltail.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_deltail.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_deltail.TabIndex = 1;
            this.gp_deltail.Text = "明细";
            // 
            // lbl_top
            // 
            this.lbl_top.AutoSize = true;
            this.lbl_top.Location = new System.Drawing.Point(114, 60);
            this.lbl_top.Name = "lbl_top";
            this.lbl_top.Size = new System.Drawing.Size(37, 19);
            this.lbl_top.TabIndex = 8;
            this.lbl_top.Text = "上级";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancel.Image = global::CS.UI.Properties.Resources.forbid;
            this.btn_cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_cancel.Location = new System.Drawing.Point(175, 306);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(60, 60);
            this.btn_cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Image = global::CS.UI.Properties.Resources.save;
            this.btn_save.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_save.Location = new System.Drawing.Point(114, 306);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(60, 60);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "保存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.ItemHeight = 23;
            this.cmb_type.Location = new System.Drawing.Point(114, 156);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 29);
            this.cmb_type.TabIndex = 5;
            this.cmb_type.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(45, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "类别";
            // 
            // txb_order
            // 
            // 
            // 
            // 
            this.txb_order.CustomButton.Image = null;
            this.txb_order.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txb_order.CustomButton.Name = "";
            this.txb_order.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_order.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_order.CustomButton.TabIndex = 1;
            this.txb_order.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_order.CustomButton.UseSelectable = true;
            this.txb_order.CustomButton.Visible = false;
            this.txb_order.Lines = new string[0];
            this.txb_order.Location = new System.Drawing.Point(114, 246);
            this.txb_order.MaxLength = 32767;
            this.txb_order.Name = "txb_order";
            this.txb_order.PasswordChar = '\0';
            this.txb_order.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_order.SelectedText = "";
            this.txb_order.SelectionLength = 0;
            this.txb_order.SelectionStart = 0;
            this.txb_order.Size = new System.Drawing.Size(121, 23);
            this.txb_order.TabIndex = 3;
            this.txb_order.UseSelectable = true;
            this.txb_order.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_order.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 246);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "顺序";
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
            this.txb_name.Location = new System.Drawing.Point(114, 106);
            this.txb_name.MaxLength = 32767;
            this.txb_name.Name = "txb_name";
            this.txb_name.PasswordChar = '\0';
            this.txb_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_name.SelectedText = "";
            this.txb_name.SelectionLength = 0;
            this.txb_name.SelectionStart = 0;
            this.txb_name.Size = new System.Drawing.Size(121, 23);
            this.txb_name.TabIndex = 1;
            this.txb_name.UseSelectable = true;
            this.txb_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "名称";
            // 
            // txb_meno
            // 
            // 
            // 
            // 
            this.txb_meno.CustomButton.Image = null;
            this.txb_meno.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txb_meno.CustomButton.Name = "";
            this.txb_meno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_meno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_meno.CustomButton.TabIndex = 1;
            this.txb_meno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_meno.CustomButton.UseSelectable = true;
            this.txb_meno.CustomButton.Visible = false;
            this.txb_meno.Lines = new string[0];
            this.txb_meno.Location = new System.Drawing.Point(114, 206);
            this.txb_meno.MaxLength = 32767;
            this.txb_meno.Name = "txb_meno";
            this.txb_meno.PasswordChar = '\0';
            this.txb_meno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_meno.SelectedText = "";
            this.txb_meno.SelectionLength = 0;
            this.txb_meno.SelectionStart = 0;
            this.txb_meno.Size = new System.Drawing.Size(121, 23);
            this.txb_meno.TabIndex = 10;
            this.txb_meno.UseSelectable = true;
            this.txb_meno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_meno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 206);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "备注";
            // 
            // GoodsManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 404);
            this.Controls.Add(this.gp_deltail);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GoodsManage";
            this.Text = "GoodsType";
            this.Load += new System.EventHandler(this.GoodsManage_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree)).EndInit();
            this.gp_deltail.ResumeLayout(false);
            this.gp_deltail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.AdvTree.AdvTree advTree;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btn_type_add;
        private DevComponents.DotNetBar.ButtonItem btn_type_edit;
        private DevComponents.DotNetBar.ButtonItem btn_type_del;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_deltail;
        private MetroFramework.Controls.MetroLabel lbl_top;
        private DevComponents.DotNetBar.ButtonX btn_cancel;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private MetroFramework.Controls.MetroComboBox cmb_type;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txb_order;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txb_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txb_meno;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
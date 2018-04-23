namespace CS.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.BarManager = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.topbar = new DevComponents.DotNetBar.DockSite();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.KIM = new DevComponents.DotNetBar.ButtonItem();
            this.kim_author = new DevComponents.DotNetBar.ButtonItem();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.sTC = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.welcome = new DevComponents.DotNetBar.SuperTabItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_dic = new DevComponents.DotNetBar.ButtonItem();
            this.dockSite1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.panelDockContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTC)).BeginInit();
            this.sTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.BarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.BarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.BarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.BarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.BarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.BarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.BarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.BarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.BarManager.BottomDockSite = this.dockSite4;
            this.BarManager.EnableFullSizeDock = false;
            this.BarManager.LeftDockSite = this.dockSite1;
            this.BarManager.ParentForm = this;
            this.BarManager.RightDockSite = this.dockSite2;
            this.BarManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.BarManager.ToolbarBottomDockSite = this.dockSite8;
            this.BarManager.ToolbarLeftDockSite = this.dockSite5;
            this.BarManager.ToolbarRightDockSite = this.dockSite6;
            this.BarManager.ToolbarTopDockSite = this.topbar;
            this.BarManager.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite4.Location = new System.Drawing.Point(20, 595);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(741, 0);
            this.dockSite4.TabIndex = 7;
            this.dockSite4.TabStop = false;
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Controls.Add(this.bar1);
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.bar1, 177, 509)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite1.Location = new System.Drawing.Point(20, 86);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(180, 509);
            this.dockSite1.TabIndex = 4;
            this.dockSite1.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.bar1.AutoSyncBarCaption = true;
            this.bar1.CloseSingleTab = true;
            this.bar1.Controls.Add(this.panelDockContainer1);
            this.bar1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockContainerItem1});
            this.bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(177, 509);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "功能";
            // 
            // panelDockContainer1
            // 
            this.panelDockContainer1.Controls.Add(this.advTree1);
            this.panelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDockContainer1.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer1.Name = "panelDockContainer1";
            this.panelDockContainer1.Size = new System.Drawing.Size(171, 483);
            this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer1.Style.GradientAngle = 90;
            this.panelDockContainer1.TabIndex = 0;
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.AllowDrop = true;
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advTree1.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.advTree1.Location = new System.Drawing.Point(0, 0);
            this.advTree1.Name = "advTree1";
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Size = new System.Drawing.Size(171, 483);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.TabIndex = 0;
            this.advTree1.Text = "advTree1";
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
            // dockContainerItem1
            // 
            this.dockContainerItem1.Control = this.panelDockContainer1;
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "功能";
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(761, 86);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 509);
            this.dockSite2.TabIndex = 5;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(20, 595);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(741, 0);
            this.dockSite8.TabIndex = 11;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(20, 86);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 509);
            this.dockSite5.TabIndex = 8;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(761, 86);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 509);
            this.dockSite6.TabIndex = 9;
            this.dockSite6.TabStop = false;
            // 
            // topbar
            // 
            this.topbar.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.topbar.Controls.Add(this.bar2);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(20, 60);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(741, 26);
            this.topbar.TabIndex = 10;
            this.topbar.TabStop = false;
            // 
            // bar2
            // 
            this.bar2.AccessibleDescription = "DotNetBar Bar (bar2)";
            this.bar2.AccessibleName = "DotNetBar Bar";
            this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar2.IsMaximized = false;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.KIM});
            this.bar2.Location = new System.Drawing.Point(0, 0);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(56, 26);
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar2.TabIndex = 0;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // KIM
            // 
            this.KIM.Name = "KIM";
            this.KIM.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.kim_author,
            this.btn_dic});
            this.KIM.Text = "KIM";
            // 
            // kim_author
            // 
            this.kim_author.Name = "kim_author";
            this.kim_author.Text = "author";
            this.kim_author.Click += new System.EventHandler(this.kim_author_Click);
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(20, 86);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(741, 0);
            this.dockSite3.TabIndex = 6;
            this.dockSite3.TabStop = false;
            // 
            // sTC
            // 
            this.sTC.BackColor = System.Drawing.SystemColors.Menu;
            this.sTC.CloseButtonOnTabsVisible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.sTC.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.sTC.ControlBox.MenuBox.Name = "";
            this.sTC.ControlBox.Name = "";
            this.sTC.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sTC.ControlBox.MenuBox,
            this.sTC.ControlBox.CloseBox});
            this.sTC.Controls.Add(this.superTabControlPanel1);
            this.sTC.Controls.Add(this.panelEx1);
            this.sTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTC.ForeColor = System.Drawing.Color.Black;
            this.sTC.Location = new System.Drawing.Point(200, 86);
            this.sTC.Name = "sTC";
            this.sTC.ReorderTabsEnabled = true;
            this.sTC.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.sTC.SelectedTabIndex = 0;
            this.sTC.Size = new System.Drawing.Size(561, 509);
            this.sTC.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sTC.TabIndex = 0;
            this.sTC.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.welcome});
            this.sTC.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 30);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(561, 479);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.welcome;
            // 
            // welcome
            // 
            this.welcome.AttachedControl = this.superTabControlPanel1;
            this.welcome.GlobalItem = false;
            this.welcome.Name = "welcome";
            this.welcome.Text = "欢迎";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(561, 509);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.StyleMouseDown.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.panelEx1.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.panelEx1.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            this.panelEx1.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.StyleMouseOver.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground;
            this.panelEx1.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.panelEx1.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.panelEx1.TabIndex = 1;
            // 
            // btn_dic
            // 
            this.btn_dic.Name = "btn_dic";
            this.btn_dic.Text = "dictionary";
            this.btn_dic.Click += new System.EventHandler(this.btn_dic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 615);
            this.Controls.Add(this.sTC);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.dockSite8);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.dockSite1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.panelDockContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTC)).EndInit();
            this.sTC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.DotNetBarManager BarManager;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite topbar;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.SuperTabControl sTC;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem welcome;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.ButtonItem KIM;
        private DevComponents.DotNetBar.ButtonItem kim_author;
        private DevComponents.DotNetBar.ButtonItem btn_dic;
    }
}


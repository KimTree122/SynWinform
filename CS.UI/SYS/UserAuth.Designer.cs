namespace CS.UI.SYS
{
    partial class UserAuth
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
            this.gb_all = new System.Windows.Forms.GroupBox();
            this.tree_allauth = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.gb_userauth = new System.Windows.Forms.GroupBox();
            this.tree_user = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.gb_oper = new System.Windows.Forms.GroupBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.gb_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tree_allauth)).BeginInit();
            this.gb_userauth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tree_user)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_all
            // 
            this.gb_all.Controls.Add(this.tree_allauth);
            this.gb_all.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_all.Location = new System.Drawing.Point(5, 36);
            this.gb_all.Name = "gb_all";
            this.gb_all.Size = new System.Drawing.Size(200, 474);
            this.gb_all.TabIndex = 0;
            this.gb_all.TabStop = false;
            this.gb_all.Text = "全权限";
            // 
            // tree_allauth
            // 
            this.tree_allauth.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.tree_allauth.AllowDrop = true;
            this.tree_allauth.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.tree_allauth.BackgroundStyle.Class = "TreeBorderKey";
            this.tree_allauth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tree_allauth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_allauth.Location = new System.Drawing.Point(3, 22);
            this.tree_allauth.Name = "tree_allauth";
            this.tree_allauth.NodesConnector = this.nodeConnector1;
            this.tree_allauth.NodeStyle = this.elementStyle1;
            this.tree_allauth.PathSeparator = ";";
            this.tree_allauth.Size = new System.Drawing.Size(194, 449);
            this.tree_allauth.Styles.Add(this.elementStyle1);
            this.tree_allauth.TabIndex = 0;
            this.tree_allauth.Text = "advTree1";
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
            // gb_userauth
            // 
            this.gb_userauth.Controls.Add(this.tree_user);
            this.gb_userauth.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_userauth.Location = new System.Drawing.Point(381, 36);
            this.gb_userauth.Name = "gb_userauth";
            this.gb_userauth.Size = new System.Drawing.Size(200, 474);
            this.gb_userauth.TabIndex = 1;
            this.gb_userauth.TabStop = false;
            this.gb_userauth.Text = "用户权限";
            // 
            // tree_user
            // 
            this.tree_user.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.tree_user.AllowDrop = true;
            this.tree_user.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.tree_user.BackgroundStyle.Class = "TreeBorderKey";
            this.tree_user.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tree_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_user.Location = new System.Drawing.Point(3, 22);
            this.tree_user.Name = "tree_user";
            this.tree_user.NodesConnector = this.nodeConnector2;
            this.tree_user.NodeStyle = this.elementStyle2;
            this.tree_user.PathSeparator = ";";
            this.tree_user.Size = new System.Drawing.Size(194, 449);
            this.tree_user.Styles.Add(this.elementStyle2);
            this.tree_user.TabIndex = 1;
            this.tree_user.Text = "advTree1";
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // gb_oper
            // 
            this.gb_oper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_oper.Location = new System.Drawing.Point(205, 36);
            this.gb_oper.Name = "gb_oper";
            this.gb_oper.Size = new System.Drawing.Size(176, 474);
            this.gb_oper.TabIndex = 2;
            this.gb_oper.TabStop = false;
            this.gb_oper.Text = "权限操作";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(5, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(576, 35);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(5, 510);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(576, 35);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 10;
            // 
            // UserAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 547);
            this.Controls.Add(this.gb_oper);
            this.Controls.Add(this.gb_userauth);
            this.Controls.Add(this.gb_all);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Name = "UserAuth";
            this.Text = "UserAuth";
            this.Load += new System.EventHandler(this.UserAuth_Load);
            this.gb_all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tree_allauth)).EndInit();
            this.gb_userauth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tree_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_all;
        private System.Windows.Forms.GroupBox gb_userauth;
        private System.Windows.Forms.GroupBox gb_oper;
        private DevComponents.AdvTree.AdvTree tree_allauth;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.AdvTree tree_user;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
    }
}
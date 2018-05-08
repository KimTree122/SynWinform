namespace CS.UI.WorkForm
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
            this.panel_inorout = new DevComponents.DotNetBar.PanelEx();
            this.panel_in = new DevComponents.DotNetBar.PanelEx();
            this.panel_out = new DevComponents.DotNetBar.PanelEx();
            this.SuspendLayout();
            // 
            // panel_inorout
            // 
            this.panel_inorout.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_inorout.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_inorout.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_inorout.Location = new System.Drawing.Point(12, 185);
            this.panel_inorout.Name = "panel_inorout";
            this.panel_inorout.Size = new System.Drawing.Size(122, 100);
            this.panel_inorout.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_inorout.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_inorout.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_inorout.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_inorout.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_inorout.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_inorout.Style.GradientAngle = 90;
            this.panel_inorout.TabIndex = 0;
            this.panel_inorout.Text = "选择";
            // 
            // panel_in
            // 
            this.panel_in.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_in.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_in.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_in.Location = new System.Drawing.Point(216, 174);
            this.panel_in.Name = "panel_in";
            this.panel_in.Size = new System.Drawing.Size(122, 100);
            this.panel_in.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_in.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_in.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_in.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_in.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_in.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_in.Style.GradientAngle = 90;
            this.panel_in.TabIndex = 7;
            this.panel_in.Text = "IN";
            // 
            // panel_out
            // 
            this.panel_out.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_out.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_out.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_out.Location = new System.Drawing.Point(88, 79);
            this.panel_out.Name = "panel_out";
            this.panel_out.Size = new System.Drawing.Size(122, 100);
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
            this.ClientSize = new System.Drawing.Size(338, 297);
            this.Controls.Add(this.panel_out);
            this.Controls.Add(this.panel_in);
            this.Controls.Add(this.panel_inorout);
            this.DoubleBuffered = true;
            this.Name = "FrmCheckServer";
            this.Text = "FrmCheckServer";
            this.Load += new System.EventHandler(this.FrmCheckServer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panel_inorout;
        private DevComponents.DotNetBar.PanelEx panel_in;
        private DevComponents.DotNetBar.PanelEx panel_out;
    }
}
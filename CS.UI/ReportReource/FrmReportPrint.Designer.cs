namespace CS.UI.ReportReource
{
    partial class FrmReportPrint
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
            this.panel_main = new DevComponents.DotNetBar.PanelEx();
            this.btn_print = new DevComponents.DotNetBar.ButtonX();
            this.btn_design = new DevComponents.DotNetBar.ButtonX();
            this.btn_printer = new DevComponents.DotNetBar.ButtonX();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_main.Controls.Add(this.btn_printer);
            this.panel_main.Controls.Add(this.btn_print);
            this.panel_main.Controls.Add(this.btn_design);
            this.panel_main.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(579, 428);
            this.panel_main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_main.Style.GradientAngle = 90;
            this.panel_main.TabIndex = 0;
            // 
            // btn_print
            // 
            this.btn_print.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_print.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_print.Location = new System.Drawing.Point(65, 196);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(147, 51);
            this.btn_print.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "打印";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_design
            // 
            this.btn_design.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_design.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_design.Location = new System.Drawing.Point(65, 103);
            this.btn_design.Name = "btn_design";
            this.btn_design.Size = new System.Drawing.Size(147, 51);
            this.btn_design.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_design.TabIndex = 0;
            this.btn_design.Text = "设计";
            this.btn_design.Click += new System.EventHandler(this.btn_design_Click);
            // 
            // btn_printer
            // 
            this.btn_printer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_printer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_printer.Location = new System.Drawing.Point(65, 294);
            this.btn_printer.Name = "btn_printer";
            this.btn_printer.Size = new System.Drawing.Size(147, 51);
            this.btn_printer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_printer.TabIndex = 2;
            this.btn_printer.Text = "打印机";
            this.btn_printer.Click += new System.EventHandler(this.btn_printer_Click);
            // 
            // FrmReportPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 428);
            this.Controls.Add(this.panel_main);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmReportPrint";
            this.Text = "FrmReportPrint";
            this.Load += new System.EventHandler(this.FrmReportPrint_Load);
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panel_main;
        private DevComponents.DotNetBar.ButtonX btn_print;
        private DevComponents.DotNetBar.ButtonX btn_design;
        private DevComponents.DotNetBar.ButtonX btn_printer;
    }
}
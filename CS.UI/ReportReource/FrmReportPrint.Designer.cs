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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new DevComponents.DotNetBar.PanelEx();
            this.txb_path = new System.Windows.Forms.TextBox();
            this.btn_printer = new DevComponents.DotNetBar.ButtonX();
            this.btn_print = new DevComponents.DotNetBar.ButtonX();
            this.btn_design = new DevComponents.DotNetBar.ButtonX();
            this.dgv = new MetroFramework.Controls.MetroGrid();
            this.btn_load = new DevComponents.DotNetBar.ButtonX();
            this.btn_add = new DevComponents.DotNetBar.ButtonX();
            this.btn_del = new DevComponents.DotNetBar.ButtonX();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_main.Controls.Add(this.btn_del);
            this.panel_main.Controls.Add(this.btn_add);
            this.panel_main.Controls.Add(this.btn_load);
            this.panel_main.Controls.Add(this.dgv);
            this.panel_main.Controls.Add(this.txb_path);
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
            // txb_path
            // 
            this.txb_path.Location = new System.Drawing.Point(12, 196);
            this.txb_path.Name = "txb_path";
            this.txb_path.Size = new System.Drawing.Size(147, 26);
            this.txb_path.TabIndex = 3;
            // 
            // btn_printer
            // 
            this.btn_printer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_printer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_printer.Location = new System.Drawing.Point(12, 126);
            this.btn_printer.Name = "btn_printer";
            this.btn_printer.Size = new System.Drawing.Size(147, 51);
            this.btn_printer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_printer.TabIndex = 2;
            this.btn_printer.Text = "打印机";
            this.btn_printer.Click += new System.EventHandler(this.btn_printer_Click);
            // 
            // btn_print
            // 
            this.btn_print.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_print.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_print.Location = new System.Drawing.Point(12, 69);
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
            this.btn_design.Location = new System.Drawing.Point(12, 12);
            this.btn_design.Name = "btn_design";
            this.btn_design.Size = new System.Drawing.Size(147, 51);
            this.btn_design.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_design.TabIndex = 0;
            this.btn_design.Text = "设计";
            this.btn_design.Click += new System.EventHandler(this.btn_design_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(250, 94);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(317, 178);
            this.dgv.TabIndex = 4;
            // 
            // btn_load
            // 
            this.btn_load.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_load.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_load.Location = new System.Drawing.Point(69, 301);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(147, 51);
            this.btn_load.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "读取";
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_add
            // 
            this.btn_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_add.Location = new System.Drawing.Point(236, 301);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 51);
            this.btn_add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "新增";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_del.Location = new System.Drawing.Point(408, 301);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(147, 51);
            this.btn_del.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_del.TabIndex = 7;
            this.btn_del.Text = "删除";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
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
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panel_main;
        private DevComponents.DotNetBar.ButtonX btn_print;
        private DevComponents.DotNetBar.ButtonX btn_design;
        private DevComponents.DotNetBar.ButtonX btn_printer;
        private System.Windows.Forms.TextBox txb_path;
        private DevComponents.DotNetBar.ButtonX btn_del;
        private DevComponents.DotNetBar.ButtonX btn_add;
        private DevComponents.DotNetBar.ButtonX btn_load;
        private MetroFramework.Controls.MetroGrid dgv;
    }
}
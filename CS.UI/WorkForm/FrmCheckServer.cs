using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.UI.WorkForm
{
    public partial class FrmCheckServer : BaseTabFrom
    {
        public FrmCheckServer()
        {
            InitializeComponent();
        }

        private List<PanelEx> panellist = new List<PanelEx>();

        private void FrmCheckServer_Load(object sender, EventArgs e)
        {
            InitControl();
            
        }

        private void InitControl()
        {
            panel_in.Dock = DockStyle.Fill;
            panel_inorout.Dock = DockStyle.Fill;
            panel_out.Dock = DockStyle.Fill;

            panellist.Add(panel_in);
            panellist.Add(panel_out);
            panellist.Add(panel_inorout);
        }


        private void ShowPanel(PanelEx panel)
        {
            //foreach (Control pan in this.Controls)
            //{
            //    if ( pan is PanelEx)
            //    {
            //        if (pan.Name == panel.Name)
            //        {
            //            pan.Visible = true;
            //        }
            //        else
            //        {
            //            pan.Visible = false;
            //        }
            //    }
            //}
            foreach (PanelEx item in panellist)
            {
                if (item.Name == panel.Name)
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }


        }
    }
}

using CS.BLL.BaseInfo;
using CS.Models.BaseInfo;
using CS.Models.Work;
using CS.UI.DataTools;
using DevComponents.DotNetBar;
using KControl;
using MetroFramework.Controls;
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

        private const string QR = "QR";
        private const string emptystring = "";
        private const int rating = 1;
        private int oper = 0;
        private List<PanelEx> panellist = new List<PanelEx>();
        private CustomInfo customInfo;
        private CustomInfoService customService = new CustomInfoService();
        private ServerTypeService serverTypeSer = new ServerTypeService();
        private List<ServerType> serverTypelist = new List<ServerType>();

        private NodesTools nodesTools = new NodesTools();

        private void FrmCheckServer_Load(object sender, EventArgs e)
        {
            InitControl();
            InitData();
        }

        private void InitData()
        {
            serverTypelist = serverTypeSer.GetAllServerTypes(SYSUser.id);
        }

        private void InitControl()
        {
            panel_in.Dock = DockStyle.Fill;
            panel_inorout.Dock = DockStyle.Fill;
            panel_out.Dock = DockStyle.Fill;

            panellist.Add(panel_in);
            panellist.Add(panel_out);
            panellist.Add(panel_inorout);

            ShowPanel(panel_inorout);
        }

        private void ShowPanel(PanelEx panel)
        {
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

        private void ClearData()
        {
            txb_custom.Text = emptystring;
            txb_name.Text = emptystring;
            txb_predate.Text = emptystring;
            txb_tel.Text = emptystring;
            dgv.DataSource = null;
            Tree_cs.Nodes.Clear();
            ratingStar.RatingValue = rating;
            rtxb_des.Text = emptystring;
            pb_qr.Image = null;
            gb_cs.Visible = false;
            ribbonBar.Enabled = false;
            panel_detail.Visible = false;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string query = txb_custom.Text.Trim().ToUpper();
            if (query.Length == 0) return;
            
            bool cs = query.StartsWith(QR);
            if (cs)
                FindInfoByQR(query);
            else
                FinInfoByOther(query);
        }

        private void FinInfoByOther(string query)
        {
            customInfo = customService.FindCustomByTel(query);
            ClearData();
            if (customInfo == null)
            {
                if (ShowQuestionMessageBox("未查询该客户，是否在该界面添加？")== DialogResult.Yes)
                {
                    gb_custom.Enabled = true;
                    ShowPanel(panel_in);
                }
            }
            else
            {
                txb_name.Text = customInfo.Cname;
                txb_tel.Text = customInfo.CTel;
                gb_custom.Enabled = false;
                ribbonBar.Enabled = true;
                nodesTools.ShowTreeView<ServerType>(Tree_cs,serverTypelist,false);
                ShowPanel(panel_in);
            }
        }

        private void FindInfoByQR(string query)
        {
            
        }

        private void plan_back_Click(object sender, EventArgs e)
        {
            ClearData();
            ShowPanel(panel_inorout);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddStauts();
        }

        private void AddStauts()
        {
            panel_detail.Visible = true;
            gb_cs.Visible = true;
            oper = 1;
            StepItem item = new StepItem("", "新增");
            progressSteps.Items.Add(item);
        }

        private void btn_modi_Click(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }
    }

}

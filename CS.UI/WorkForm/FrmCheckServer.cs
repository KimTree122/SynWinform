using CS.BLL.BaseInfo;
using CS.BLL.Work;
using CS.Models;
using CS.Models.BaseInfo;
using CS.Models.ViewModel;
using CS.Models.Work;
using CS.UI.DataTools;
using DevComponents.AdvTree;
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

        private const string QR = "CS";
        private const string emptystring = "";
        private const string CsStauts = "售后状态";
        private const int rating = 1;
        private int oper = 0;
        private List<PanelEx> panellist = new List<PanelEx>();
        private CustomInfo customInfo;
        private CustomInfoService customService = new CustomInfoService();
        private ServerTypeService serverTypeSer = new ServerTypeService();
        private CustomHistoryService historyService = new CustomHistoryService();
        private CheckInService checkInService = new CheckInService();
        private List<ServerType> serverTypelist = new List<ServerType>();
        private List<Sysdic> ScStautlist = new List<Sysdic>();
        private Sysdic frist_ScStauts;

        private NodesTools nodesTools = new NodesTools();

        private void FrmCheckServer_Load(object sender, EventArgs e)
        {
            InitControl();
            InitData();
        }

        private void InitData()
        {
            serverTypelist = serverTypeSer.GetAllServerTypes(SYSUser.id);
            ScStautlist = SysdicSer.GetSysdicsbyType(CsStauts);
            if (ScStautlist.Count == 0)
            {
                ShowTipsMessageBox("基础数据获取失败,请重新开启");
            }
            else
            {
                frist_ScStauts = ScStautlist[0];
            }

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

            gb_cs.Visible = false;
            txb_servertype.Tag = 0;
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
            txb_servertype.Text = emptystring;
            lbl_qrcode.Text = emptystring;
            txb_servertype.Tag = 0;
            txb_name.Tag = 0;
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
                if (ShowQuestionMessageBox("未查询该客户，是否在该界面添加？") == DialogResult.Yes)
                {
                    gb_custom.Enabled = true;
                    ShowPanel(panel_in);
                }
            }
            else
            {
                txb_name.Text = customInfo.Cname;
                txb_name.Tag = customInfo.id;
                txb_tel.Text = customInfo.CTel;
                gb_custom.Enabled = false;
                ribbonBar.Enabled = true;
                nodesTools.ShowTreeView<ServerType>(Tree_cs, serverTypelist, false);
                GetHistory(customInfo.id);
                ShowPanel(panel_in);
            }
        }

        private void GetHistory(int id)
        {
            List<CustomHistoryVM> vMs = historyService.GetCustomHistoryVMs(id);
            dgv.DataSource = vMs;
            dgv.Columns["id"].Visible = false;
            dgv.Columns["TypeName"].HeaderText = "类型";
            dgv.Columns["CheckDate"].HeaderText = "登记";
            dgv.Columns["Dicname"].HeaderText = "状态";
            dgv.Columns["FinishDate"].HeaderText = "完成";
            if (vMs.Count > 0)
            {
                FixControlData();
            }
        }

        private void FixControlData()
        {
            panel_detail.Visible = true;
            panel_detail.Enabled = false;
            int row = dgv.SelectedCells[0].RowIndex;
            string mtid = dgv["id", row].Value.ToString();
            PostData<CheckInDT, CheckInMT> post = checkInService.GetCheckInDTMT(mtid);
            CheckInMT mT = post.Entity;
            List<CheckInDT> dtlist = post.DList;
            if (post.MCount == 0) return;
            
            rtxb_des.Text = mT.Memo;

            string st = serverTypelist.Find( s => s.id == mT.ServerTypeID).TreeName;

            txb_servertype.Text = st;
            pb_qr.Image = QRManage.GetQRCodeByZXingNet(mT.QRcode, pb_qr.Width, pb_qr.Height);
            foreach (CheckInDT dt in dtlist)
            {
                string staut = ScStautlist.Find(s => s.id == dt.GoodsStauts).Dicval;
                
                StepItem item = new StepItem("", staut);
                progressSteps.Items.Add(item);
                ratingStar.Rating = (int) dt.Rating;
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
            StepItem item = new StepItem("", frist_ScStauts.Dicname);
            progressSteps.Items.Add(item);
        }

        private void btn_modi_Click(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            EnterStauts();
        }

        private void EnterStauts()
        {
            switch (oper)
            {
                case 1:
                    AddCheckIn();
                    break;
                case 2:
                    EditCheckIn();
                    break;
            }
        }

        private void EditCheckIn()
        {

        }

        private void AddCheckIn()
        {
            if ((int)txb_servertype.Tag == 0)
            {
                ShowTipsMessageBox("未选中服务类型");
                return;
            }
            if ((int)txb_name.Tag == 0)
            {
                ShowTipsMessageBox("请补充客户信息");
                return;
            }

            string qrcode = checkInService.GetQrnumber(SYSUser.id);

            CheckInMT mT = new CheckInMT
            {
                CheckDate = DateTime.Now.ToShortDateString(),
                CustomID = (int)txb_name.Tag,
                Memo = rtxb_des.Text.Trim(),
                delflag = false,
                ServerTypeID = (int)txb_servertype.Tag,
                ServerStauts = frist_ScStauts.id,
                QRcode = qrcode
            };
            int id = checkInService.AddCheckInMT(mT);
            if (id == 0)
            {
                ShowTipsMessageBox("");
                return;
            }

            CheckInDT dT = new CheckInDT
            {
                CheckData = DateTime.Now.ToShortDateString(),
                CheckInID = id,
                delflag = false,
                Rating = ratingStar.Rating,
                Meno = emptystring,
                GoodsStauts = frist_ScStauts.id
            };

            int iddt = checkInService.AddCheckInDT(dT);
            if (iddt > 0)
            {
                ShowTipsMessageBox("添加成功");
                pb_qr.Image = QRManage.GetQRCodeByZXingNet(qrcode, pb_qr.Width, pb_qr.Height);
                lbl_qrcode.Text = qrcode;
            }

        }

        private void Tree_cs_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            GetNodeText();
        }

        private void GetNodeText()
        {
            Node treeNode = Tree_cs.SelectedNode;
            if (treeNode == null) return;
            ServerType serverType = (ServerType)treeNode.Tag;
            txb_servertype.Text = serverType.TreeName;
            txb_servertype.Tag = serverType.id;
        }

        private void lbl_sertype_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gb_cs.Visible = !gb_cs.Visible;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FixControlData();
        }
    }

}

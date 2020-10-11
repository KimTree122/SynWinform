using CS.BLL;
using CS.BLL.BaseInfo;
using CS.BLL.Work;
using CS.UI.DataTools;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using KControl;
using KNDBsys.Model;
using KNDBsys.Model.BaseInfo;
using KNDBsys.Model.ViewModel;
using KNDBsys.Model.Work;
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

            txb_custom.KeyDown += Txb_custom_KeyDown;
        }

        private void Txb_custom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) FindData();

        }

        private void Plan_back_Click(object sender, EventArgs e)
        {
            ClearData();
            ShowPanel(panel_inorout);
        }

        private void Btn_find_Click(object sender, EventArgs e)
        {
            FindData();
        }

        private void FindData()
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
                InitCustomControl();
                GetHistory(customInfo.id);
                ShowPanel(panel_in);
            }
        }

        private void FindInfoByQR(string query)
        {
            int customid = checkInService.GetCustomidByQR(query);
            if (customid == 0)
            {
                ShowTipsMessageBox("未能查询信息，请重新输入");
                txb_custom.Text = "";
            }
            else
            {
                customInfo = customService.FindCustomByid(customid);
                if (customInfo.id != 0)
                {
                    InitCustomControl();
                    GetHistory(customInfo.id);
                    ShowPanel(panel_in);
                }
            }
        }

        private void InitCustomControl()
        {
            txb_name.Text = customInfo.Cname;
            txb_name.Tag = customInfo.id;
            txb_tel.Text = customInfo.CTel;
            gb_custom.Enabled = false;
            ribbonBar.Enabled = true;
            nodesTools.ShowTreeView<ServerType>(Tree_cs, serverTypelist, false);
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
            if (vMs.Count > 0) FixControlData();
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FixControlData();
        }

        private void FixControlData()
        {
            int row = dgv.SelectedCells[0].RowIndex;
            string mtid = dgv["id", row].Value.ToString();
            PostData<CheckInDT, CheckInMT> post = checkInService.GetCheckInDTMT(mtid);
            if (post.total == 0)
            {
                ShowErrorMessageBox("获取失败，请重新点击");
                return;
            } 

            CheckInMT mT = post.Entity;
            List<CheckInDT> dtlist = post.rows;
            rtxb_mtmemo.Text = mT.Memo;
            pb_qr.Tag = mtid.ToInt();
            string st = serverTypelist.Find( s => s.id == mT.ServerTypeID).TreeName;
            txb_servertype.Text = st;
            pb_qr.Image = QRManage.GetQRCodeByZXingNet(mT.QRcode, pb_qr.Width, pb_qr.Height);

            CleanSetpItems();
            foreach (CheckInDT dt in dtlist)
            {
                AddProgressSetp(dt);
            }

            panel_detail.Visible = true;
            panel_detail.Enabled = false;
            panel_mt.Visible = true;
            lbl_sertype.Enabled = false;
            rtxb_mtmemo.Enabled = false;
            DetailBtnVisible(true);

        }

        private void AddProgressSetp(CheckInDT dt)
        {
            Sysdic staut = ScStautlist.Find(s => s.id == dt.GoodsStauts);
            StepItem item = new StepItem(staut.id.ToString(), staut.Dicval);
            item.Tag = dt;
            progressSteps.Items.Add(item);
            ratingStar.Rating = (int)dt.Rating;
            lbl_dtmemo.Text = dt.Meno;
            nud_cost.Value = (int)dt.ServerPay;
            progressSteps.Refresh();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AddStauts();
        }

        private void AddStauts()
        {
            panel_mt.Visible = true;
            gb_cs.Visible = true;
            txb_servertype.Text = emptystring;
            txb_servertype.Tag = 0;
            rtxb_mtmemo.Text = emptystring;
            pb_qr.Image = null;
            lbl_qrcode.Text = emptystring;
            panel_detail.Visible = true;
            ratingStar.Rating = 0;
            lbl_dtmemo.Text = emptystring;
            rtxb_mtmemo.Enabled = true;
            lbl_sertype.Enabled = true;
            Btn_adddt.Visible = false;
            btn_print.Visible = false;
            CleanSetpItems();
            oper = 1;
        }

        private void CleanSetpItems()
        {
            for (int i = 0; i < progressSteps.Items.Count; i++)
            {
                progressSteps.Items.RemoveAt(i);
                i--;
            }
        }

        private void Btn_modi_Click(object sender, EventArgs e)
        {

        }

        private void Btn_del_Click(object sender, EventArgs e)
        {

        }

        private void Btn_creat_Click(object sender, EventArgs e)
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
            int id = AddCheckInMT(qrcode);
            if (id == 0)
            {
                ShowErrorMessageBox("添加失败");
                return;
            }

            AddCheckInDT(qrcode, id);

        }

        private void AddCheckInDT(string qrcode, int id)
        {
            CheckInDT dT = new CheckInDT
            {
                CheckData = DateTime.Now.ToShortDateString(),
                CheckInID = id,
                delflag = false,
                Rating = ratingStar.Rating,
                Meno = frist_ScStauts.Dicval,
                GoodsStauts = frist_ScStauts.id
            };

            int iddt = checkInService.AddCheckInDT(dT);
            if (iddt > 0)
            {
                ShowTipsMessageBox("添加成功");
                pb_qr.Image = QRManage.GetQRCodeByZXingNet(qrcode, pb_qr.Width, pb_qr.Height);
                lbl_qrcode.Text = qrcode;

                StepItem item = new StepItem(frist_ScStauts.id.ToString(), frist_ScStauts.Dicname);
                progressSteps.Items.Add(item);
                Btn_adddt.Visible = true;
                btn_print.Visible = true;
                GetHistory((int) txb_name.Tag);

            }
            oper = 0;
        }

        private int AddCheckInMT(string qrcode)
        {
            CheckInMT mT = new CheckInMT
            {
                CheckDate = DateTime.Now.ToShortDateString(),
                CustomID = (int)txb_name.Tag,
                Memo = rtxb_mtmemo.Text.Trim(),
                delflag = false,
                ServerTypeID = (int)txb_servertype.Tag,
                ServerStauts = frist_ScStauts.id,
                QRcode = qrcode
            };
            int id = checkInService.AddCheckInMT(mT);
            return id;
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

        private void Lbl_sertype_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gb_cs.Visible = !gb_cs.Visible;
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {

        }

        private void Btn_enter_Click(object sender, EventArgs e)
        {

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
            txb_finishdate.Text = emptystring;
            txb_tel.Text = emptystring;
            txb_servertype.Text = emptystring;
            lbl_qrcode.Text = emptystring;
            txb_servertype.Tag = 0;
            txb_name.Tag = 0;
            dgv.DataSource = null;
            Tree_cs.Nodes.Clear();
            ratingStar.RatingValue = rating;
            rtxb_mtmemo.Text = emptystring;
            pb_qr.Image = null;
            gb_cs.Visible = false;
            ribbonBar.Enabled = false;
            panel_detail.Visible = false;
            panel_mt.Visible = false;

        }

        private void Btn_adddt_Click(object sender, EventArgs e)
        {
            ShowAddCheckInDT();
            oper = 2;
        }

        private void ShowAddCheckInDT()
        {
            FrmCheckInDTAdd frm = new FrmCheckInDTAdd((int)pb_qr.Tag, ScStautlist, AddCheckInDT);
            frm.ShowDialog();
        }

        private int AddCheckInDT(CheckInDT checkInDT)
        {
            int id = checkInService.AddCheckInDT(checkInDT);
            if (id > 0)
            {
                checkInDT.id = id;
                ratingStar.Rating =(int)checkInDT.Rating;
                lbl_dtmemo.Text = checkInDT.Meno;
                AddProgressSetp(checkInDT);
                btn_creat.Visible = true;
            }
            else
            {
                ShowErrorMessageBox("添加失败");
            }
            return id;
        }

        private void progressSteps_ItemClick(object sender, EventArgs e)
        {
            ProgressStepsClick(sender);
        }

        private void ProgressStepsClick(object sender)
        {
            StepItem item = (StepItem)sender;
            CheckInDT dt = (CheckInDT)item.Tag;
            ratingStar.Rating = (int)dt.Rating;
            lbl_dtmemo.Text = dt.Meno;
            nud_cost.Value = (int) dt.ServerPay;
            int count = progressSteps.Items.Count;
            StepItem lastitem = (StepItem)progressSteps.Items[count - 1];
            CheckInDT dTlast = (CheckInDT)lastitem.Tag;
            bool islast = dt.id == dTlast.id;
            DetailBtnVisible(islast);
        }

        private void DetailBtnVisible(bool islast)
        {
            btn_creat.Visible = islast;
            btn_back.Visible = islast;
            panel_detail.Enabled = islast;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            panel_detail.Visible = false;
            panel_mt.Visible = false;
        }
    }

}

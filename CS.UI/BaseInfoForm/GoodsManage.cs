using CS.BLL.BaseInfo;
using CS.UI.DataTools;
using DevComponents.AdvTree;
using KNDBsys.Model.BaseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.UI.BaseInfoForm
{
    public partial class GoodsManage : BaseTabFrom
    {
        public GoodsManage()
        {
            InitializeComponent();
        }

        private ServerTypeService sts = new ServerTypeService();
        private NodesTools nodesTools = new NodesTools();
        private List<ServerType> serverTypes = new List<ServerType>();
        private ServerType currentSerType;

        private int oper = 0;

        private void GoodsManage_Load(object sender, EventArgs e)
        {
            InitControl();
            InitData();
        }

        private void InitControl()
        {
            SysdicSer.ComboBoxBindbyType(cmb_type, "售后类别");
        }

        private void InitData()
        {
            serverTypes = sts.GetAllServerTypes(SYSUser.id);
            nodesTools.ShowTreeView<ServerType>(advTree, serverTypes, false);
        }

        private void btn_type_add_Click(object sender, EventArgs e)
        {
            AddStauts();
        }

        private void AddStauts()
        {
            oper = 1;
            gp_deltail.Enabled = true;
            txb_name.Text = "";
            txb_order.Text = "";
        }

        private void btn_type_edit_Click(object sender, EventArgs e)
        {
            EditStauts();
        }

        private void EditStauts()
        {
            oper = 2;
            gp_deltail.Enabled = true;
        }

        private void btn_type_del_Click(object sender, EventArgs e)
        {
            DeleteNode();
        }

        private void DeleteNode()
        {
            if (ShowQuestionMessageBox("确认要删除："+currentSerType.TreeName+"?")== DialogResult.Yes)
            {
                bool c = serverTypes.Remove(currentSerType);
                if (c)
                {
                    nodesTools.ShowTreeView<ServerType>(advTree, serverTypes, false);
                    ShowTipsMessageBox("删除成功");
                }
                else
                {
                    ShowErrorMessageBox("删除失败");
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case 1:Add();
                    break;

                case 2:UpDate();
                    break;
            }
            gp_deltail.Enabled = false;
            oper = 0;
        }

        private void UpDate()
        {
            ServerType server = GetControlServerType(currentSerType.id,currentSerType.ParentID);
            bool u = sts.UpdateServerType(server);
            if (u)
            {
                int q = serverTypes.FindIndex(s => s.id == server.id);
                serverTypes[q] = server;
                nodesTools.ShowTreeView<ServerType>(advTree, serverTypes, false);
                ShowTipsMessageBox("更新成功！");
            }
            else
            {
                ShowErrorMessageBox("更新失败");
            }
        }

        private void Add()
        {
            int fid = currentSerType == null ? 0 : currentSerType.id;
            ServerType server = GetControlServerType(0,fid);
            int id = sts.AddServerType(server);
            if (id > 0)
            {
                server.id = id;
                serverTypes.Add(server);
                nodesTools.ShowTreeView<ServerType>(advTree, serverTypes, false);
                ShowTipsMessageBox("新增成功！");
            }
            else
            {
                ShowErrorMessageBox("新增失败！");
            }
        }

        private ServerType GetControlServerType(int id = 0,int? parentid = 0)
        {
            ServerType server = new ServerType { id = id, delflag = false, ParentID = parentid, TMemo = txb_meno.Text.Trim(), TOrder = txb_order.Text.Trim(), TreeName = txb_name.Text.Trim(), Typeid = cmb_type.SelectedValue.ToString(), TypeName = cmb_type.Text };
            return server;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            gp_deltail.Enabled = false;
            oper = 0;
        }

        private void advTree_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            FixControl();
        }

        private void FixControl()
        {
            Node node = advTree.SelectedNode;
            
            if (node != null)
            {
                ServerType s = (ServerType)node.Tag;
                txb_name.Text = s.TreeName;
                currentSerType = s;
                txb_order.Text = s.TOrder;
                txb_meno.Text = s.TMemo;
                if (node.Parent != null)
                {
                    ServerType fs = (ServerType)node.Parent.Tag;
                    lbl_top.Text = fs.TreeName;
                }
                else
                {
                    lbl_top.Text = "顶级";
                }
            }
        }
    }
}

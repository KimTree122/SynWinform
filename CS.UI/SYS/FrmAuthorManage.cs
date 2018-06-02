using CS.BLL.BaseInfo;
using CS.Models.BaseInfo;
using CS.UI.DataTools;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.UI.SYS
{
    public partial class FrmAuthorManage : BaseTabFrom
    {
        public FrmAuthorManage()
        {
            InitializeComponent();
        }

        private AuthorityService authorityService = new AuthorityService();
        private NodesTools nodesTools = new NodesTools();

        private List<Authority> authorities;
        private int oper;
        private Authority CAuth;

        private void FrmAuthorManage_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            LoadAuthType();
            LoadAuth();
        }

        private void LoadAuth()
        {
            SysdicSer.ComboBoxBindbyType(cmb_type, "权限类型");
        }

        private void LoadAuthType()
        {
            authorities = authorityService.GetAuthorities(SYSUser.id);
            ShowTreeView();
        }

        private void AddAuth()
        {
            int aid;
            if (CAuth == null)
            {
                aid = 0;
            }
            else
            {
                aid = cb_top.Checked ? 0 : CAuth.id;
            }
             
            Authority auth = GetEditAuth(aid);
            int id = authorityService.AddAuthority(auth);
            if (id != 0)
            {
                auth.id = id;
                authorities.Add(auth);
                ShowTreeView();
                ShowTipsMessageBox("添加成功");
            }
            
        }

        private void EditAuth()
        {
            int f = lbl_father.Tag == null ? 0 : (int)lbl_father.Tag;
            f = cb_top.Checked ? 0 : f;
            Authority auth = GetEditAuth(f, CAuth.id);
            bool id = authorityService.UpdateAuthority(auth);
            if (id)
            {
                Authority au = (Authority)txb_name.Tag;
                authorities.Remove(au);
                authorities.Add(auth);
                ShowTipsMessageBox("修改成功");
            }
            else
            {
                ShowTipsMessageBox("修改失败");
            }
        }

        private void DelAuth()
        {
            int f = lbl_father.Tag == null ? 0 : (int)lbl_father.Tag;
            Authority auth = GetEditAuth(f, CAuth.id);
            bool id = authorityService.DeleteAuthority(auth);
            if (id)
            {
                Authority a = (Authority)txb_name.Tag;
                authorities.Remove(a);
                ShowTreeView();
                ShowTipsMessageBox("删除成功");
            }
            else
            {
                ShowTipsMessageBox("删除失败");
            }
        }

        private void TreeSelect()
        {
            Node node = advTree.SelectedNode;
            if (node == null) return;

            CAuth = (Authority)node.Tag;

            txb_name.Text = CAuth.TreeName;
            txb_name.Tag = CAuth;
            txb_order.Text = CAuth.AOrder;
            txb_path.Text = CAuth.Path;
            cmb_type.Text = CAuth.AuthTypeName;

            Node pnode = node.Parent;
            if (pnode == null)
            {
                lbl_father.Text = "顶级";
                cb_top.Checked = true;
                return;
            }
            Authority pau = (Authority)pnode.Tag;
            lbl_father.Text = pau.TreeName;
            lbl_father.Tag = pau.id;
            cb_top.Checked = false;
        }

        private Authority GetEditAuth(int fid, int id = 0)
        {
            Authority authority = new Authority { AOrder = txb_order.Text, TreeName = txb_name.Text, AuthTypeID = (int)cmb_type.SelectedValue, AuthTypeName = cmb_type.Text, Path = txb_path.Text, ParentID = fid, Imageid = 0, id = id };
            return authority;
        }

        private void ShowTreeView()
        {
            advTree.Nodes.Clear();
            nodesTools.ShowTreeView<Authority>(advTree,authorities,false );
        }

        private void CleanText()
        {
            txb_name.Text = "";
            txb_path.Text = "";
            txb_order.Text = "";
            cb_top.Checked = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Node node = advTree.SelectedNode;
            if (node == null) return;
            lbl_father.Text = node.Text;
            oper = 1;
            CleanText();
            gb.Enabled = true;
        }

        private void btn_modi_Click(object sender, EventArgs e)
        {
            oper = 2;
            gb.Enabled = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dr = ShowWarningMessageBox("是否确认删除？");
            if (dr == DialogResult.Yes)
            {
                DelAuth();
            }
        }

        private void advTree_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            TreeSelect();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case 1:AddAuth();
                    break;
                case 2:EditAuth();
                    break;
                case 3:DelAuth();
                    break;
                default:
                    break;
            }
            oper = 0;
            gb.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            CleanText();
            gb.Enabled = false;
        }
    }
}

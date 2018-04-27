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
        private AuthNodes authNodes = new AuthNodes();

        private List<Authority> authorities;
        private List<TreeNode> treeNodes;
        private Authority ChooseAuth;



        private void FrmAuthorManage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadAuthType();
            LoadAuth();
        }

        private void LoadAuth()
        {
            ComboBoxBind.ComboBoxData(cmb_type, "权限类型");
        }

        private void LoadAuthType()
        {
            authorities = authorityService.GetAuthorities(SYSUser.id);
        }

        private void AddAuth()
        {
            Authority auth = GetEditAuth();
            int id = authorityService.AddAuthority(auth);
            if (id != 0)
            {
                auth.id = id;
                authorities.Add(auth);
                ShowTreeView();
                ShowTipsMessageBox("添加成功");
            }
        }

        private void ShowTreeView()
        {
            treeNodes = authNodes.CreatTreeNodes(authorities);
            foreach (TreeNode tn in treeNodes)
            {
                Node node = new Node();
                
                advTree.Nodes.Add(node);
            }
        }

        private Authority GetEditAuth(int id = 0)
        {
            Authority authority = new Authority { AOrder = txb_order.Text, AuthName = txb_name.Text, AuthTypeID = (int)cmb_type.SelectedValue, AuthTypeName = cmb_type.Text, Path = txb_path.Text, ParentID = (int)lbl_father.Tag, Imageid = 0, id = id };
            return authority;
        }



    }
}

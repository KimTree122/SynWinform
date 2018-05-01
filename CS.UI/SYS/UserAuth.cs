using CS.BLL.BaseInfo;
using CS.Models.BaseInfo;
using CS.UI.DataTools;
using DevComponents.AdvTree;
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
    public partial class UserAuth : BaseTabFrom
    {
        public UserAuth()
        {
            InitializeComponent();
        }

        private AuthorityService authorityService = new AuthorityService();
        private AuthNodes authNodes = new AuthNodes();

        private List<Authority> allauths;
        private List<Node> treeNodes;

        private void UserAuth_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            InitUser();
            InitAllAuth();
        }

        private void InitUser()
        {
            List<string> userlist = new List<string>();
            foreach (UserInfo ui in SYSData.userInfos)
            {
                string str = ui.Uname + "-" + ui.UPost + "-" + ui.id;
                userlist.Add(str);
            }
            txblist_user.BindData(userlist);
            txblist_copy.BindData(userlist);

        }

        private void InitAllAuth()
        {
            allauths = authorityService.GetAuthorities(SYSUser.id);
            ShowTreeView(allauths);
        }

        private void ShowTreeView(List<Authority> auths )
        {
            tree_allauth.Nodes.Clear();
            treeNodes = authNodes.CreatTreeNodes(auths, true);
            foreach (Node tn in treeNodes)
            {
                tree_allauth.Nodes.Add(tn);
            }
            tree_allauth.ExpandAll();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }

        private void btn_copy_Click(object sender, EventArgs e)
        {

        }

        private void btn_sel_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class UserAuthManage : BaseTabFrom
    {
        public UserAuthManage()
        {
            InitializeComponent();
        }

        private AuthorityService authorityService = new AuthorityService();
        private AuthNodes authNodes = new AuthNodes();

        private List<Authority> allauths;

        private List<Authority> userauths;

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
            ShowTreeView(tree_allauth, allauths);
        }

        private void ShowTreeView(AdvTree adv, List<Authority> auths )
        {
            adv.Nodes.Clear();
            List<Node> nodes = authNodes.CreatTreeNodes(auths, true);
            foreach (Node tn in nodes)
            {
                adv.Nodes.Add(tn);
            }
            adv.ExpandAll();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddUserAuth();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DelUserAuth();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            CopyAuth();
        }

        private void btn_sel_Click(object sender, EventArgs e)
        {
            SelectUser();
        }

        private void AddUserAuth()
        {
            List<Authority> add = authNodes.GetCheckNode(tree_allauth.Nodes);

            List<Authority> useradd = authorityService.AddUserAuth(add, txblist_user.Tag.ToString());
            if (useradd.Count == 0) ShowTipsMessageBox("授权失败");
            userauths.AddRange(useradd);
            ShowTreeView(tree_user, userauths);

        }

        private void DelUserAuth()
        {
            List<UserAuth> userauths = new List<UserAuth>();

            List<Authority> checkauth = authNodes.GetUserNode(tree_user.Nodes);
            foreach (Authority auth in checkauth)
            {
                UserAuth userAuth = new UserAuth { AuthID = auth.id, UserID = int.Parse(txblist_user.Tag.ToString()) };
                userauths.Add(userAuth);
            }
            authorityService.DeleteUserAuth(userauths, txblist_user.Tag.ToString());
            SelectUser();

        }

        private void CopyAuth()
        {
            bool check = authorityService.CopyUserAuth(txblist_user.Tag.ToString(), txblist_copy.Tag.ToString());
            if (check)
                ShowTipsMessageBox("复制成功");
            else
                ShowErrorMessageBox("复制失败");
        }

        private void SelectUser()
        {
            userauths = authorityService.GetUserAuth(txblist_user.Tag.ToString());
            ShowTreeView(tree_user, userauths);
        }

    }
}

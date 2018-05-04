using CS.BLL.BaseInfo;
using CS.Models.BaseInfo;
using CS.UI.DataTools;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CS.UI
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SYSUser.id = 1;
            InitControl();
            InitCommonData();
        }

        private void InitControl()
        {
#if DEBUG
            topbar.Visible = true;
#endif
        }

        private void InitCommonData()
        {
            UserInfoService userInfoService = new UserInfoService();
            SYSData.userInfos = userInfoService.GetAllUserinfo(SYSUser.id);

            AuthorityService authorityService = new AuthorityService();
            NodesTools authNodes = new NodesTools();
            List<Authority> userauths = authorityService.GetUserAuth(SYSUser.id.ToString());

            var fun = userauths.Where(u => u.AuthTypeName.Contains("功能") || u.AuthTypeName.Contains("模块")).ToList();
            authNodes.ShowTreeView(tree_auth, fun, false);

            var oper = userauths.Where(u => u.AuthTypeName.Contains("编辑")).ToList() ;
            SYSUser.OperAuth = oper;

        }

        private void AddTabForm(string TabName,string TabPath)
        {
            bool isopen = true;
            foreach (SuperTabItem item in sTC.Tabs)
            {
                if (item.Name == TabName)
                {
                    sTC.SelectedTab = item;
                    isopen = false;
                    break;
                }
            }

            if (isopen)
            {
                object obj = Assembly.GetExecutingAssembly().CreateInstance("CS.UI."+TabPath, false);
                if (obj == null)
                {
                    MetroMessageBox.Show(this, "路径错误，请联系系统管理员。","警告");
                    return;
                }
                Form form = (Form)obj;
                form.TopLevel = false;
                form.Visible = true;
                form.Dock = DockStyle.Fill;
                form.Tag = "123";
                SuperTabItem item = sTC.CreateTab(TabName);
                item.Text = TabName;
                item.Name = TabName;
                item.AttachedControl.Controls.Add(form);
                sTC.SelectedTab = item;
            }
        }

        private void kim_author_Click(object sender, EventArgs e)
        {
            AddTabForm("权限管理", "SYS.FrmAuthorManage");
        }

        private void btn_dic_Click(object sender, EventArgs e)
        {
            AddTabForm("字典管理", "SYS.FrmDict");
        }

        private void btn_userauth_Click(object sender, EventArgs e)
        {
            AddTabForm("用户权限", "SYS.UserAuthManage");
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            AddTabForm("用户管理", "BaseInfoForm.FrmUserInfo");
        }

        private void tree_auth_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            Node node = tree_auth.SelectedNode;
            if (node == null) return;
            Authority auth = node.Tag as Authority;
            if (string.IsNullOrWhiteSpace(auth.Path)) return;
            AddTabForm(auth.TreeName,auth.Path);
        }
    }
}

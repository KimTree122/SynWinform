using CS.BLL.BaseInfo;
using CS.BLL.FileLoad;
using CS.UI.DataTools;
using CS.UI.SYS;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using KNDBsys.Model.BaseInfo;
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
        private FileLoadService fileLoad = new FileLoadService();

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool checkver = CheckVer();

#if DEBUG
            checkver = true;
#endif

            if (!checkver)
            {
                DialogResult dr = MetroMessageBox.Show(this, "发现新版本，请问是否升级？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    ProgressTool progress = new ProgressTool();
                    progress.RunProcess("UpgradeFile.exe");
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                LoginShow();
            }
            
        }

        private bool CheckVer()
        {
            SysVer ver = fileLoad.GetNewSysVer();
            return ver.sysver == Application.ProductVersion;
        }

        private void LoginShow()
        {
            this.Visible = false;
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            bool success = logIn.DialogResult == DialogResult.OK;
            if (success)
            {
                InitControl();
                InitCommonData();
            }
            else
            {
                this.Close();
            }
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
            SYSData.userInfos = new Lazy<List<UserInfo>>(() => userInfoService.GetAllUserinfo(SYSUser.id));

            AuthorityService authorityService = new AuthorityService();
            NodesTools authNodes = new NodesTools();
            List<Authority> userauths = authorityService.GetUserAuth(SYSUser.id.ToString(),"winform");

            var fun = userauths.Where(u => u.AuthTypeName.Contains("功能") || u.AuthTypeName.Contains("模块")).ToList();
            authNodes.ShowTreeView(tree_auth, fun, false);

            var oper = userauths.Where(u => u.AuthTypeName.Contains("编辑")).ToList();
            SYSUser.OperAuth = oper;

        }

        private void AddTabForm(string TabName, string TabPath,int authid = 0)
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
                object obj = Assembly.GetExecutingAssembly().CreateInstance("CS.UI." + TabPath, false);
                if (obj == null)
                {
                    MetroMessageBox.Show(this, "路径错误，请联系系统管理员。", "警告");
                    return;
                }
                Form form = (Form)obj;
                form.TopLevel = false;
                form.Visible = true;
                form.Dock = DockStyle.Fill;
                form.Tag = authid;
                
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
            AddTabForm("打印测试", "ReportReource.FrmReportPrint");
        }

        private void btn_userauth_Click(object sender, EventArgs e)
        {
            AddTabForm("用户权限", "SYS.UserAuthManage");
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            AddTabForm("业务中心", "WorkForm.FrmCheckServer");
        }

        private void tree_auth_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            Node node = tree_auth.SelectedNode;
            if (node == null) return;
            Authority auth = node.Tag as Authority;
            if (string.IsNullOrWhiteSpace(auth.Path)) return;
            AddTabForm(auth.TreeName, auth.Path, auth.id);
        }

        private void btn_upgrade_Click(object sender, EventArgs e)
        {
            FrmUpgrade frm = new FrmUpgrade();
            frm.ShowDialog();
        }
    }
}

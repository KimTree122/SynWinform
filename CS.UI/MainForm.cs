using CS.BLL.BaseInfo;
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
        }

        private void kim_author_Click(object sender, EventArgs e)
        {
            AddTabForm("权限管理", "SYS.FrmAuthorManage");
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
                SuperTabItem item = sTC.CreateTab(TabName);
                item.Text = TabName;
                item.Name = TabName;
                item.AttachedControl.Controls.Add(form);
                sTC.SelectedTab = item;
            }
        }

        private void btn_dic_Click(object sender, EventArgs e)
        {
            AddTabForm("字典管理", "SYS.FrmDict");
        }
    }
}

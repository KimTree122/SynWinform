using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static UpgradeFile.ZIPTool;

namespace UpgradeFile
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private FileLoadPresent fileLoadPresent = new FileLoadPresent();
        private ProgressTool progressTool = new ProgressTool();
        private string program = "ServerRecord.exe";
        private SysVer sysVer;
        private string[] filstr;


        private void Main_Load(object sender, EventArgs e)
        {
            InitListView();
            InitData();
            progressTool.KillProcess(program);
        }

        private void InitData()
        {
            PostData<SysVer, SysVer> post = fileLoadPresent.GetNewVersion();
            if (post == null || post.MCount == 0)
            {
                MetroMessageBox.Show(this, "获取版本失败，请重新获取。");
                return;
            }
            sysVer = post.Entity;

            filstr = sysVer.filelist.Split(',');

            for (int i = 0; i < filstr.Count(); i++)
            {
                ListViewItem viewItem = new ListViewItem(i + 1 + "");
                viewItem.SubItems.Add(filstr[i]);
                listView.Items.Add(viewItem);
            }

            rtxb.Text = sysVer.note;
        }

        private void InitListView()
        {
            listView.Columns.Add("序号", 60, HorizontalAlignment.Center);
            listView.Columns.Add("文件名", 100, HorizontalAlignment.Left);
        }

        private void btn_upgrade_Click(object sender, EventArgs e)
        {
            string amb = Application.StartupPath + "\\"+ program;
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(amb);
            string verstring = fvi.FileVersion;
            if (verstring == sysVer.sysver)
            {
                MetroMessageBox.Show(this, "该版本为最新版本，无需升级！");
                return;
            }

            string filepath = Application.StartupPath + "\\";
            
            string ver = sysVer.sysver + "/";
            bool zip = false;

            foreach (var str in filstr)
            {
                probar.Value = 0;
                int d = fileLoadPresent.DownLoadFile(ver+str, filepath + str, probar);
                if (d == 0)
                {
                    MetroMessageBox.Show(this, "升级文件出错，请联系管理员");
                    return;
                }
                zip = str.EndsWith(".zip");
            }
            if (zip)
            {
                FileZipOpr zipOpr = new FileZipOpr();
                zipOpr.UnZipFile(filepath + filstr[0],filepath,"",true);
                File.Delete(filepath + filstr[0]);
            }
            progressTool.RunProcess(program);
            this.Close();
        }
    }
}

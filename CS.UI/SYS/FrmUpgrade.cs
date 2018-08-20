using CS.BLL.FileLoad;
using CS.ViewModel;
using KNDBsys.Model.BaseInfo;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UpgradeFile;
using static UpgradeFile.ZIPTool;

namespace CS.UI.SYS
{
    public partial class FrmUpgrade : MetroForm
    {
        public FrmUpgrade()
        {
            InitializeComponent();
        }

        private List<FileLoadVM> filepathlist= new List<FileLoadVM>();
        private FileLoadService loadService;
        private string upgradetype = "winform";

        private void FrmUpgrade_Load(object sender, EventArgs e)
        {
            InitListView();
            InitData();
        }

        private void InitListView()
        {
            listView.Columns.Add("序号",60,HorizontalAlignment.Center);
            listView.Columns.Add("文件名", 100, HorizontalAlignment.Left);
            listView.Columns.Add("路径", 60, HorizontalAlignment.Left);
        }

        private void InitData()
        {
            loadService = new FileLoadService(StateText);
            string ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            txb_ver.Text = ver;
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.ShowDialog();
            string[] files = ofd.FileNames;
            if (files.Count() == 0) return;
            filepathlist.Clear();
            for (int i = 0; i < files.Count(); i++)
            {
                string fileName = Path.GetFileName(files[i]);
                FileLoadVM fl = new FileLoadVM { Order = i+1,FileName = fileName, FilePath = files[i] };
                filepathlist.Add(fl);
            }
            FixListView(filepathlist);

        }

        private void FixListView(List<FileLoadVM> filepathlist)
        {
            listView.Items.Clear();
            foreach (var fl in filepathlist)
            {
                ListViewItem viewItem = new ListViewItem(fl.Order+"");
                viewItem.SubItems.Add(fl.FileName);
                viewItem.SubItems.Add(fl.FilePath);
                listView.Items.Add(viewItem);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            int count = 0;
            string filelist = string.Empty;
            if (cb_zip.Checked)
            {
                if (filepathlist.Count() == 0) return;
                string path = filepathlist[0].FilePath;
                string rootpath = Path.GetDirectoryName(path);
                string verdir = rootpath + "\\" + txb_ver.Text;

                if (Directory.Exists(verdir))
                {
                    Directory.Delete(verdir, true);
                }
                Directory.CreateDirectory(verdir);
               
                foreach (var filepath in filepathlist)
                {
                    File.Copy(filepath.FilePath, verdir + "\\" + filepath.FileName);
                }
                FileZipOpr zipOpr = new FileZipOpr();
                string deszip = verdir + ".zip";
                zipOpr.ZipFileDirectory(verdir, deszip);
                Directory.Delete(verdir, true);
                count = RequestUpload(deszip);
                UpdateSysVer(count, Path.GetFileName(deszip),true);
                File.Delete(deszip);
            }
            else
            {
                foreach (var file in filepathlist)
                {
                    filelist += file.FileName + ",";
                    count = RequestUpload(file.FilePath);
                    if (count == 0) break;
                }
                filelist = UpdateSysVer(count, filelist,false);
            }
        }

        private string UpdateSysVer(int count, string filelist,bool zip)
        {
            if (count != 0)
            {
                filelist = zip ? filelist:filelist.Substring(0, filelist.Length - 1);
                SysVer sysVer = new SysVer
                {
                    sysver = txb_ver.Text,
                    note = rtxb_note.Text,
                    programtype = upgradetype,
                    upgradedate = DateTime.Now.ToLongTimeString(),
                    filelist = filelist
                };
                int id = loadService.AddSysVer(sysVer);
                if (id > 0)
                {
                    MetroMessageBox.Show(this, "上传成功");
                }
                else
                {
                    MetroMessageBox.Show(this, "上传失败，请重新上传");
                }
            }
            else
            {
                MetroMessageBox.Show(this, "上传文件失败，请重新上传");
            }

            return filelist;
        }

        private int RequestUpload(string filepath)
        {
            int i = loadService.UpLoadFile(filepath,txb_ver.Text, proBar);
            return i;
        }

        private void StateText(int type, string msg)
        {
            lbl_state.Text = msg;
        }
    }
}

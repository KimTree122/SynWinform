using CS.BLL.FileLoad;
using CS.DAL;
using CS.Models.ViewModel;
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

namespace CS.UI.SYS
{
    public partial class FrmUpgrade : MetroForm
    {
        public FrmUpgrade()
        {
            InitializeComponent();
        }

        private List<FileLoadVM> filepathlist= new List<FileLoadVM>();

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
            foreach (var file in filepathlist)
            {
                RequestUpload(file.FilePath);
            }
        }

        private void RequestUpload(string filepath)
        {
            FileLoadService loadService = new FileLoadService(StateText);
            int i = loadService.UpLoadFile(filepath, proBar);
        }

        private void StateText(int type, string msg)
        {
            lbl_state.Text = msg;
        }
    }
}

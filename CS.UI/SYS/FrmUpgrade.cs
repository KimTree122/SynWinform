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
            InitDgv();
            InitData();
        }

        private void InitDgv()
        {
            dgv.DataSource = null;
            dgv.DataSource = filepathlist;
            dgv.Columns["Order"].HeaderText = "序号";
            dgv.Columns["FileName"].HeaderText = "文件名";
            dgv.Columns["FilePath"].HeaderText = "路径";

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

            InitDgv();

            

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            RequestUpload();
        }

        private void RequestUpload()
        {
            FileLoadHelper fileLoad = new FileLoadHelper(StateText);
            string filepath = @"C:\360Downloads\Postman_v4.1.3.crx";
            string url = "http://localhost:36769/FileLoad/FileLoad/UpLoadFile";
            fileLoad.Upload_Request(url,filepath,proBar);
        }

        private void StateText(int type, string msg)
        {
            lbl_state.Text = msg;
        }
    }
}

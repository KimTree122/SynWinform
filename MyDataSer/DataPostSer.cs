using MetroFramework.Forms;
using MyDataSer.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MyDataSer
{
    public partial class DataPostSer : MetroForm
    {
        public DataPostSer()
        {
            InitializeComponent();
        }

        private GetStudentData gsd;
        private Presenter ps;

        private void DataPostSer_Load(object sender, EventArgs e)
        {
            gsd = new GetStudentData();
            ps = new Presenter();
        }

        private void mbtn_start_Click(object sender, EventArgs e)
        {
            mps.EnsureVisible = true;
            mps.Value = 80;
            PostTimer.Start();
            mbtn_start.Enabled = false;

            //string s = ps.UploadAllstudentdata();
            //MessageBox.Show(s);
          
        }

        private void mbtn_minsmall_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
           

        }

        private void DataPostSer_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)//最小化　　　　　 
            {
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ShowInTaskbar = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void PostTimer_Tick(object sender, EventArgs e)
        {
            UploadTask();
        }

        private void UploadTask()
        {
            string s = ps.UploadAllstudentdata();
            list_history.Items.Add(s);
            s = ps.UploadDiffStudentdata();
            list_history.Items.Add(s);
            s = ps.UploadHisData();
            list_history.Items.Add(s);
            s = ps.UploadHisVer();
            list_history.Items.Add(s);
        }

        private void mbtn_upload_Click(object sender, EventArgs e)
        {
            UploadTask();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                rtb.Text = ps.GetVerData(txb_serid.Text);
            }
            else
            {
                rtb.Text = ps.GetHisData(txb_serid.Text);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                string s = ps.UploadVerData(txb_serid.Text, txb_dbid.Text);
                rtb.Text = s;
            }
            else
            {
                string s = ps.UploadHisVer();

                //string s = ps.UploadHisData(txb_dbid.Text);
                rtb.Text = s;
            }
        }

        private void btn_maxid_Click(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                string s = ps.GetSerStuMaxID();
                rtb.Text = s;
            }
            else
            {
                string s = ps.GetSerHisMaxID();
                rtb.Text = s;
            }
        }
    }
}

using MetroFramework.Forms;
using Newtonsoft.Json;
using SynDSStudent.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynDSStudent
{
    public partial class FrmSynStudent : MetroForm
    {
        public FrmSynStudent()
        {
            InitializeComponent();
        }

        private SQLiteConn Sconn;
        private List<DSstudent> dslst;
        private SQLiteOper So;
        private InitData initData;

        private void FrmSynStudent_Load(object sender, EventArgs e)
        {
            LoadLocaData();
            GetLocalStudentCount();
        }

        private void GetLocalStudentCount()
        {
            lbl_local_count.Text = So.LocalStudentCount();
        }

        private void LoadLocaData()
        {
            Sconn = new SQLiteConn();
            dslst = new List<DSstudent>();
            So = new SQLiteOper();

            LoadInitData();
        }

        private void LoadInitData()
        {
            GetInitData gid = new GetInitData();
            initData = gid.LoadInitData(So.LocalStudentCount(), Sconn.CheckDataBase());
            lbl_ser_ver.Text = initData.SerVer;
            lbl_ser_count.Text = initData.SerCount;
            lbl_local_ver.Text = initData.LocVer;
            lbl_local_count.Text = initData.LocCount;
            mlbl_title.Text = initData.InitStaut;
        }

       

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
            //this.notifyIcon.Visible = false;
        }

        private void FrmSynStudent_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)//最小化　　　　　 
            {
                this.ShowInTaskbar = false;
                //this.notifyIcon.Visible = true;
            }
            else
            {
                this.ShowInTaskbar = true;
                //this.notifyIcon.Visible = false;
            }
        }

        private void btn_serversion_Click(object sender, EventArgs e)
        {
            LoadInitData();
        }

        private void btn_allload_Click(object sender, EventArgs e)
        {

            string url = HttpAPI.GetStudentLst() ;
            string ver = HttpData.GetHttp(url);

            List<DSstudent> s = HttpData.Deserialize<List<DSstudent>>(ver);
            if (s == null)
            {
                MessageBox.Show("获取失败，请重新再试");
                return;
            }
            So.DeleteStudent();
            So.ExecuteStudent(s);

            AppSetting.UpdateAppConfig("UpdateID", initData.SerVer);

            LoadInitData();

        }

        private void btn_version_Click(object sender, EventArgs e)
        {
            GetDataByVer();
        }

        private void GetDataByVer()
        {
            string url = HttpAPI.GetStudentLst() + "/" + AppSetting.GetAppConfig("UpdateID");
            string ver = HttpData.GetHttp(url);
            List<DSstudent> s = HttpData.Deserialize<List<DSstudent>>(ver);
            if (s == null)
            {
                MessageBox.Show("获取失败，请重新再试");
                return;
            }
            So.ExecuteStudent(s);
            LoadInitData();
        }

        private void btn_auto_Click(object sender, EventArgs e)
        {
            //Timer t = new Timer();
            //t.Tick += t_Tick;
            //t.Interval = 10000;
            //t.Start();

        }

        void t_Tick(object sender, EventArgs e)
        {
            GetDataByVer();
        }



    }
}

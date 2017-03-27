using MetroFramework.Forms;
using Newtonsoft.Json;
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

        private void FrmSynStudent_Load(object sender, EventArgs e)
        {
            LoadLocaData();
            GetSerStudentver();
            GetSerStudentcount();
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
            if (!Sconn.CheckDataBase())
            {
                mlbl_title.Text = "未检测到数据库";
            }
            else
            {
                mlbl_title.Text = "数据正常";
            }
        }

        private void GetSerStudentver()
        {
            string url = HttpAPI.GetServerVersion();
            string ver = HttpData.GetHttp(url);
            lbl_ser_ver.Text =HttpData.Deserialize<string>(ver);
        }

        private void GetSerStudentcount()
        {
            string url = HttpAPI.GetServerStudentCount();
            string ver = HttpData.GetHttp(url);
            lbl_ser_count.Text = HttpData.Deserialize<string>(ver);
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
            GetSerStudentver();
            GetSerStudentcount();
        }

        private void btn_allload_Click(object sender, EventArgs e)
        {
            //string url = HttpAPI.GetStudentLst();
            //string ver = HttpData.GetHttp(url);
            //List<DSstudent> s = HttpData.Deserialize<List<DSstudent>>(ver);
            //MessageBox.Show(s.Count+"个");
            string url = HttpAPI.GetStudentLst() + "/10";
            string ver = HttpData.GetHttp(url);
            List<DSstudent> s = HttpData.Deserialize<List<DSstudent>>(ver);

            So.DeleteStudent(s);

            DataTable dt = So.LocalDepGuid();

            GetLocalStudentCount();


        }

        private void btn_version_Click(object sender, EventArgs e)
        {
            string url = HttpAPI.GetStudentLst() + "/10";
            string ver = HttpData.GetHttp(url);
            List<DSstudent> s = HttpData.Deserialize<List<DSstudent>>(ver);

            So.InsterStudent(s);

            DataTable dt = So.LocalDepGuid();
            GetLocalStudentCount(); 

        }

        private void btn_auto_Click(object sender, EventArgs e)
        {
            string url = HttpAPI.GetServerStudentCount();

            StringWriter sw = new StringWriter();
            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("value");
            writer.WriteValue("123");
            writer.WriteEndObject();
            writer.Flush();
            string jsonText = sw.GetStringBuilder().ToString();
            string ver = HttpData.PostHttp(url, jsonText);

            MessageBox.Show(ver);

        }



    }
}

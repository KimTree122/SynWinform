using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DsParkOffLine
{
    public partial class ParkStudent : MetroForm
    {
        private TaskPresident tp;
        public delegate void ChangeValue(int v);

        public ParkStudent()
        {
            InitializeComponent();
        }

        private void ParkStudent_Load(object sender, EventArgs e)
        {
            tp = new TaskPresident();
            mbtn_load.Visible = tp.CheckConnect();
            mpbar.Visible = false;
        }

        private void mbtn_get_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            DSstu ds = tp.GetStuInSqlite(txb_select.Text.Trim());
            if (ds.id == 0)
            {
                MetroMessageBox.Show(this, "未查询该学员，请重新输入。"
   , "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_name.Text = "";
                lbl_NO.Text = "";
            }
            else
            {
                List<DsHistory> dhlist = tp.GetDSHisInSqllite(ds.dsid);
                foreach (var dh in dhlist)
                {
                    string his = dh.form + "-" + dh.oper + "-" + dh.rec;
                    listView.Items.Add(his);
                }
                lbl_name.Text = ds.dsname;
                lbl_NO.Text = ds.dsidno;
            }
            txb_select.Text = "";
        }

        private void mbtn_load_Click(object sender, EventArgs e)
        {
            tp.LoadSerDataThread(ShowComplete);

            //new Thread(new ThreadStart(ChangeProBarValue)).Start();
        }

        private void ChangeProBarValue()
        {
            tp.ThreadTest(UIhandlle);
        }

        private void ShowComplete()
        {
            MetroMessageBox.Show(this, "加载完成","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UIhandlle(int v)
        {
            if (mpbar.InvokeRequired)
            {
                mpbar.BeginInvoke(new ChangeValue(ChangemPbarValue), new object[] { v });
            }
            else
            {
                mpbar.Value = v;
            }
        }


        private void ChangemPbarValue(int v)
        {
            mpbar.Value = v;
        }

    }
}

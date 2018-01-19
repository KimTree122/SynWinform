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
            if (txb_select.Text.Trim().Length == 0)
            {
                Initlbl("请输入学员号");
                return;
            }
            ShowHis();

            //List<DsHistory> dhlist = tp.GetDSHisInSqlite(txb_select.Text.Trim());
            //if (dhlist.Count() > 0)
            //{
            //    foreach (var dh in dhlist)
            //    {
            //        string his = dh.form + "-" + dh.oper + "-" + dh.rec;
            //        listView.Items.Add(his);
            //    }
            //    lbl_name.Text = dhlist[0].name;
            //    lbl_NO.Text = dhlist[0].dsidno;
            //}
            //else
            //{
            //    Initlbl("未查询该学员，请重新输入。");
            //}
            //txb_select.Text = "";




            //DSstu ds = tp.GetStuInSqlite(txb_select.Text.Trim());
            //if (ds.id == 0)
            //{
            //    Initlbl("未查询该学员，请重新输入。");
            //}
            //else
            //{
            //    List<DsHistory> dhlist = tp.GetDSHisInSqlite(ds.dsno);
            //    foreach (var dh in dhlist)
            //    {
            //        string his = dh.form + "-" + dh.oper + "-" + dh.rec;
            //        listView.Items.Add(his);
            //    }
            //    lbl_name.Text = ds.dsname;
            //    lbl_NO.Text = ds.dsidno;
            //}
            //txb_select.Text = "";
        }

        private void ShowHis()
        {
            ImportExcelCls iec = tp.GetImport(txb_select.Text.Trim());
            if (iec.dsid != "0" )
            {
                listView.Items.Add("报名日期 -- " + iec.checkin);
                listView.Items.Add("技能证   -- " + iec.skilldate);
                listView.Items.Add("科一     -- " + iec.ky);
                listView.Items.Add("科二     -- " + iec.ke);
                listView.Items.Add("科三     -- " + iec.ks);
                listView.Items.Add("科四     -- " + iec.kms);
                lbl_name.Text = iec.name;
                lbl_NO.Text = iec.dsid;
            }
            else
            {
                Initlbl("未查询该学员，请重新输入。");
            }
            txb_select.Text = "";
        }

        private void Initlbl(string str)
        {
            MetroMessageBox.Show(this, str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl_name.Text = "";
            lbl_NO.Text = "";
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

        private void mbtn_import_Click(object sender, EventArgs e)
        {
            tp.importData(this);
        }

    }
}

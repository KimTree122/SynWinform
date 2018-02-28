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
            //mbtn_load.Visible = tp.CheckConnect();
            mpbar.Visible = false;
        }

        private void mbtn_get_Click(object sender, EventArgs e)
        {
            
            if (txb_select.Text.Trim().Length == 0)
            {
                Initlbl("请输入学员号");
                return;
            }
            ShowHis();
        }

        private void ShowHis()
        {
            listView.Items.Clear();
            ImportExcelCls iec = tp.GetImport(txb_select.Text.Trim());
            if (iec.dsid.Length != 0 )
            {
                if (iec.dsno.Length == 0)
                {
                    listView.Items.Add("登记日期 -- " + iec.checkin);
                    Initlbl("此人员在黑名单中");
                    ChangeTextColor(true);
                }
                else
                {
                    listView.Items.Add("报名日期 -- " + iec.checkin);
                    listView.Items.Add("技能证   -- " + iec.skilldate);
                    listView.Items.Add("科一     -- " + iec.ky);
                    listView.Items.Add("科二     -- " + iec.ke);
                    listView.Items.Add("科三     -- " + iec.ks);
                    listView.Items.Add("科四     -- " + iec.kms);
                    ChangeTextColor(false);
                }
                
                lbl_name.Text = iec.name;
                lbl_NO.Text = iec.dsid;
            }
            else
            {
                Initlbl("未查询该学员，请重新输入。");
            }
            txb_select.Text = "";
        }

        private void ChangeTextColor(bool c) 
        {
            Color color = c ? Color.Red : Color.Black;

            lbl_name.ForeColor = color;
            lbl_NO.ForeColor = color;
            listView.ForeColor = color;

        } 

        private void Initlbl(string str)
        {
            MetroMessageBox.Show(this, str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl_name.Text = "";
            lbl_NO.Text = "";
        }


        private void ChangeProBarValue()
        {
            tp.ThreadTest(UIhandlle);
            //tp.LoadSerDataThread(ShowComplete);
            //new Thread(new ThreadStart(ChangeProBarValue)).Start();
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

        private void mbtn_blacklist_Click(object sender, EventArgs e)
        {
            BlackList bl = new BlackList(ClearData);
            bl.ShowDialog();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DelConfirm dc = new DelConfirm(ClearData,lbl_NO.Text);
            dc.ShowDialog();
        }

        public void ClearData()
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
             DialogResult dr = MetroMessageBox.Show(this, "测试", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (dr == DialogResult.Yes)
             {
                 MessageBox.Show("yes");
             }
             if (dr == DialogResult.No)
             {
                 MessageBox.Show("no");
             }


            ClearData();
        }

    }
}

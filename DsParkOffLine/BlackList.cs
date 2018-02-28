using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DsParkOffLine
{
    public partial class BlackList : MetroForm
    {
        public delegate void ClearData();
        private ClearData clearData;
        private TaskPresident tp = new TaskPresident();

        public BlackList()
        {
            InitializeComponent();
        }

        public BlackList(ClearData cd)
        {
            InitializeComponent();
            clearData = cd;
        }



        private void BlackList_Load(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            bool check = CheckData();
            if (check) return;

            ImportExcelCls iE = new ImportExcelCls();
            iE.name = txb_Name.Text.Trim();
            iE.dsid = txb_ID.Text.Trim();
            iE.checkin = dtp.Value.ToShortDateString();
            bool c = tp.AddBlackListName(iE);
            if (c)
            {
                ShowDialog("新增成功");
                txb_Name.Text = "";
                txb_ID.Text = "";
                clearData();
            }
            else
            {
                ShowDialog("可能存在相同身份证，请重新输入");
                clearData();
            }
        }

        private bool CheckData()
        {
            if (txb_Name.Text.Trim().Length == 0)
            {
                ShowDialog("请输入姓名！");
                return true;
            }
            if ( txb_ID.Text.Trim().Length == 0)
            {
                ShowDialog("请输入身份证号！");
                return true;
            }
            return false;

        }


        private void ShowDialog(string str)
        {
            MetroMessageBox.Show(this, str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

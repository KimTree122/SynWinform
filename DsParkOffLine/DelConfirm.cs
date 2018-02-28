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
    public partial class DelConfirm : MetroForm
    {
        public delegate void ClearData();
        private ClearData clearData;
        private string DsID;
        private TaskPresident tp = new TaskPresident();

        public DelConfirm()
        {
            InitializeComponent();
        }

        public DelConfirm(ClearData c,string dsid) 
        {
            InitializeComponent();
            clearData = c ;
            DsID = dsid;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txb_pwd.Text.ToUpper().Trim() != "GZ82728383") 
            {
                ShowDialog("密码错误");
                return;
            }

            DeleteHis();

        }

        private void DeleteHis()
        {
            int count = tp.GetHisCountByDSid(DsID);
            if (count > 1)
            {
                DialogResult dr = MetroMessageBox.Show(this, "查询有" + count + "个重复身份证号 \r\n 是否全部删除？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    bool c = tp.DeleteDShis(DsID);
                    if (c) ShowDialog("删除成功");
                    
                }
            }
            else if (count == 1)
            {
                bool c = tp.DeleteDShis(DsID);
                if (c) ShowDialog("删除成功");
            }
            else
            {
                ShowDialog("未查询对应身份证学员");
            }
        }

        private void ShowDialog(string str)
        {
            MetroMessageBox.Show(this, str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

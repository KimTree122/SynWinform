using CS.BLL.BaseInfo;
using CS.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.UI.SYS
{
    public partial class FrmDict : BaseTabFrom
    {
        private BaseInfoService baseInfoService = new BaseInfoService();
        private int oper;

        public FrmDict()
        {
            InitializeComponent();
        }

        private void FrmDict_Load(object sender, EventArgs e)
        {
            LoadDicType(); 
        }

        private void LoadDicType()
        {
            List<Sysdic> cSDics = baseInfoService.GetDicByType("类型");
            foreach (var item in cSDics)
            {
                cmb_dictype.Items.Add(item.Dicname);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            oper = 1;
            FrmDictDialog frm = new FrmDictDialog(ReLoad);
            frm.ShowDialog();
        }

        private void ReLoad(Sysdic cSDicTionary)
        {
            switch (oper)
            {
                case 1:
                    MessageBox.Show("add");
                    break;
                case 2:
                    MessageBox.Show("modi");
                    break;
                case 3:
                    MessageBox.Show("del");
                    break;
                default:
                    break;
            }
        }

    }
}

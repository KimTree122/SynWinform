using CS.BLL.BaseInfo;
using CS.Models.BaseInfo;
using MetroFramework;
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
        private List<Sysdic> sysdics = new List<Sysdic>();
        private string FirstItem = "类型";

        public FrmDict()
        {
            InitializeComponent();
        }

        private void FrmDict_Load(object sender, EventArgs e)
        {
            LoadDicType();
            LoadData();
        }

        private void LoadData()
        {
            dgv.DataSource = sysdics;
            dgv.Columns["id"].Visible = false; 
            dgv.Columns["Dicname"].HeaderText = "类型";
            dgv.Columns["Dickey"].HeaderText = "键";
            dgv.Columns["Dicval"].HeaderText = "值";
            dgv.Columns["DicMeno"].HeaderText = "备注";
            dgv.Columns["Dicsetp"].HeaderText = "排序";
        }

        private void LoadDicType()
        {
            cmb_dictype.Items.Add(FirstItem);
            cmb_dictype.Text = FirstItem;
            GetDicData();
            AddCmbItem();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            oper = 1;
            FrmDictDialog frm = new FrmDictDialog(ReLoad,cmb_dictype.Text);
            frm.ShowDialog();
        }

        private void ReLoad(Sysdic dic)
        {
            switch (oper)
            {
                case 1:
                    sysdics.Add(dic);
                    break;
                case 2:
                    Updatedgv(dic);
                    break;
                default:
                    break;
            }

            dgv.Refresh();
        }

        private void Delete(Sysdic dic)
        {
            DialogResult dr = MetroMessageBox.Show(this, "是否确定删除\r\n" + dic.Dicval + "?", "提示", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                bool check = baseInfoService.DleteDictionary(dic);
                if (check)
                {
                    dgv.DataSource = null;
                    sysdics.Remove(dic);
                    LoadData();
                }
                else
                {
                    MetroMessageBox.Show(this,"删除失败","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
        }

        private void Updatedgv(Sysdic dic)
        {
            int index = sysdics.FindIndex(i => i.id == dic.id);
            sysdics.RemoveAt(index);
            sysdics.Insert(index, dic);
        }

        private void cmb_dictype_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDicData();
        }

        private void GetDicData()
        {
            string type = cmb_dictype.Text;
            List<Sysdic> cSDics = baseInfoService.GetDicByType(type);
            sysdics = cSDics;
            dgv.DataSource = sysdics;
        }

        private void AddCmbItem()
        {
            foreach (var item in sysdics)
            {
                cmb_dictype.Items.Add(item.Dicval);
            }
        }

        private void btn_modi_Click(object sender, EventArgs e)
        {
            oper = 2;
            int row = dgv.SelectedCells[0].RowIndex;
            List<Sysdic> dics = dgv.DataSource as List<Sysdic>;
            Sysdic sysdic = dics[row];
            FrmDictDialog frm = new FrmDictDialog(ReLoad, sysdic);
            frm.Show();

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int row = dgv.SelectedRows[0].Index;
            Sysdic del = sysdics[row];
            Delete(del);
        }
    }
}

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

namespace CS.UI.BaseInfoForm
{
    public partial class FrmCustomInfo : BaseTabFrom
    {
        public FrmCustomInfo()
        {
            InitializeComponent();
        }

        private List<CustomInfo> customlist = new List<CustomInfo>();
        private CustomInfoService cIS = new CustomInfoService();
        private CustomInfo CurrentCustom;
        private int oper = 0;

        private void FrmCustomInfo_Load(object sender, EventArgs e)
        {
            InitControl();
            InitData();
        }

        private void InitControl()
        {
            FixDGV();
        }

        private void FixDGV()
        {
            dgv.DataSource = null;
            dgv.DataSource = customlist;
            dgv.Columns["id"].Visible = false;
            dgv.Columns["delflag"].Visible = false;
            dgv.Columns["Cname"].HeaderText = "称呼";
            dgv.Columns["CTel"].HeaderText = "电话";
            dgv.Columns["Caddress"].HeaderText = "地址";
            dgv.Columns["Cmeno"].HeaderText = "备注";
        }

        private void InitData()
        {
            customlist = cIS.GetAllCustomInfos(SYSUser.id);
            FixDGV();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddStauts();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditStauts();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DeleteCustomInfo();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            CancelEdit();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FixControl();
        }

        private void FixControl()
        {
            int row = dgv.SelectedRows[0].Index;
            if (row == -1) return;
            CurrentCustom = customlist[row];
            txb_name.Text = CurrentCustom.Cname;
            txb_tel.Text = CurrentCustom.CTel;
            txb_address.Text = CurrentCustom.Caddress;
            txb_meno.Text = CurrentCustom.Cmeno;
        }

        private void AddStauts()
        {
            oper = 1;
            split_con.Panel1Collapsed = false;
            txb_name.Text = "";
            txb_tel.Text = "";
            txb_address.Text = "";
            txb_meno.Text = "";
        }

        private void EditStauts()
        {
            oper = 2;
            split_con.Panel1Collapsed = false;
        }

        private void DeleteCustomInfo()
        {
            CurrentCustom.delflag = true;
            bool c = cIS.UpdateCustomInfo(CurrentCustom);
            if (c)
            {
                int index = customlist.FindIndex(ci => ci.id == CurrentCustom.id);
                customlist.RemoveAt(index);
                FixDGV();
                ShowTipsMessageBox("删除成功");
            }
            else
            {
                ShowErrorMessageBox("删除失败");
            }
        }

        private void SaveData()
        {
            switch (oper)
            {
                case 1:AddCustom();
                    break;
                case 2: UpdateCustom();
                    break;
            }
            oper = 0;
            split_con.Panel1Collapsed = true;
        }

        private void UpdateCustom()
        {
            if (CheckData()) return;

            CurrentCustom.Cmeno = txb_meno.Text.Trim();
            CurrentCustom.Caddress = txb_address.Text.Trim();
            CurrentCustom.Cname = txb_name.Text.Trim();
            CurrentCustom.CTel = txb_tel.Text.Trim();
            bool c = cIS.UpdateCustomInfo(CurrentCustom);
            if (c)
            {
                int index = customlist.FindIndex(ci => ci.id == CurrentCustom.id);
                customlist[index] = CurrentCustom;
                dgv.RefreshEdit();
                ShowTipsMessageBox("编辑成功");
            }
            else
            {
                ShowErrorMessageBox("编辑失效");
            }
        }

        private void AddCustom()
        {
            if (CheckData()) return;

            CustomInfo ci = new CustomInfo { Caddress = txb_address.Text.Trim(),
             Cmeno = txb_meno.Text.Trim(), Cname = txb_name.Text.Trim(), CTel = txb_tel.Text.Trim(), delflag = false};
            int id = cIS.AddCustomInfo(ci);
            if (id > 0)
            {
                ci.id = id;
                customlist.Add(ci);
                FixDGV();
                ShowTipsMessageBox("添加成功");
            }
            else
            {
                ShowErrorMessageBox("添加失败");
            }
        }

        public bool CheckData()
        {
            int count = cIS.CountcustomTel(txb_tel.Text.Trim());
            if (count > 0)
            {
                ShowTipsMessageBox("已有相同手机号码");
                return true;
            }
            return false;
        }

        private void CancelEdit()
        {
            oper = 0;
            split_con.Panel1Collapsed = true;
        }


    }
}

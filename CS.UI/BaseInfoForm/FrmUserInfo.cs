using CS.BLL.BaseInfo;
using DevComponents.DotNetBar;
using KNDBsys.Model.BaseInfo;
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
    public partial class FrmUserInfo : BaseTabFrom
    {
        public FrmUserInfo()
        {
            InitializeComponent();
        }

        private UserInfoService uiS = new UserInfoService();
        List<UserInfo> userInfolist = new List<UserInfo>();
        private int oper;

        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            InitData();
            Fixdgv();
        }

        private void Fixdgv()
        {
            dgv.DataSource = null;
            dgv.DataSource = userInfolist;
            dgv.Columns["Uname"].HeaderText = "姓名";
            dgv.Columns["Utel"].HeaderText = "电话";
            dgv.Columns["UPost"].HeaderText = "职位";
            dgv.Columns["Uaccount"].HeaderText = "账号";
            dgv.Columns["id"].Visible = false;
            dgv.Columns["Upwd"].Visible = false;
            dgv.Columns["delflag"].Visible = false;
        }

        private void InitData()
        {
            SysdicSer.ComboBoxBindbyType(cmb_post, "职位类型");
            GetAllUser();
        }

        private void GetAllUser()
        {
            userInfolist = uiS.GetAllUserinfo(SYSUser.id);
            FixControl(0);
        }

        private void FixControl(int row)
        {
            if (userInfolist.Count() > 0)
            {
                UserInfo user = userInfolist[row];
                txb_name.Text = user.Uname;
                txb_tel.Text = user.Utel;
                cmb_post.Text = user.UPost;
                txb_name.Tag = user.id;
                txb_account.Text = user.Uaccount;
            }
            else
            {
                txb_name.Tag = 0;
            }
        }

        private void btn_visiable_Click(object sender, EventArgs e)
        {
            split_Con.Panel1Collapsed = !split_Con.Panel1Collapsed;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Addstauts();
        }

        private void Addstauts()
        {
            oper = 1;
            btn_enter.Enabled = true;
            gp.Enabled = true;
            split_Con.Panel1Collapsed = false;
            split_Con.SplitterDistance = 250;
            txb_name.Text = "";
            txb_tel.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Updatestauts();
        }

        private void Updatestauts()
        {
            DataGridViewSelectedRowCollection dgrs = dgv.SelectedRows;
            if (dgrs == null) return;
            oper = 2;
            btn_enter.Enabled = true;
            gp.Enabled = true;
            split_Con.Panel1Collapsed = false;
            split_Con.SplitterDistance = 250;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void SaveData()
        {
            switch (oper)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Editdata();
                    break;
            }
            oper = 0;
            btn_enter.Enabled = false;
            gp.Enabled = false;
        }

        private void Add()
        {
            UserInfo user = ControlUserInfo();
            int id = uiS.Adduserinfo(user);
            if (id > 0) 
            {
                user.id = id;
                userInfolist.Add(user);
                Fixdgv();
                split_Con.Panel1Collapsed = true;
                ShowTipsMessageBox("添加成功");
            }
            else
            {
                ShowErrorMessageBox("添加失败");
            }
        }

        private UserInfo ControlUserInfo()
        {
            return new UserInfo { Uname = txb_name.Text, delflag = false, UPost = cmb_post.Text, Utel = txb_tel.Text, Upwd = txb_tel.Text.Trim(), Uaccount = txb_account.Text.Trim(), id = (int)txb_name.Tag };
        }

        private void Editdata()
        {
            UserInfo user = ControlUserInfo();
            bool c = uiS.Updateuserinfo(user);
            if (c)
            {
                int index = userInfolist.FindIndex( e => e.id == user.id);
                userInfolist.RemoveAt(index);
                userInfolist.Insert(index, user);
                dgv.Refresh();
                split_Con.Panel1Collapsed = true;
                ShowTipsMessageBox("编辑成功");
            }
            else
            {
                ShowErrorMessageBox("更新失败");
            }

        }

        private void DeleteUser()
        {
            UserInfo user = ControlUserInfo();
            DialogResult dr = ShowQuestionMessageBox("确实要删除："+user+"?");
            if (dr == DialogResult.Yes)
            {
                user.delflag = true;
                bool c = uiS.Deleteuserinfo(user);
                if (c)
                {
                    int index = userInfolist.FindIndex(u => u.id == user.id);
                    userInfolist.RemoveAt(index);
                    Fixdgv();
                    ShowTipsMessageBox("删除成功");
                }
                else
                {
                    ShowErrorMessageBox("删除失败");
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            oper = 0;
            btn_enter.Enabled = false;
            gp.Enabled = false;
            split_Con.Panel1Collapsed = true;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgv.SelectedCells[0].RowIndex;
            FixControl(row);
        }
    }
}

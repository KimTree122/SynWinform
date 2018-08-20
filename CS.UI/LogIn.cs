using CS.BLL.BaseInfo;
using KNDBsys.Model.BaseInfo;
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

namespace CS.UI
{
    public partial class LogIn : MetroForm
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private UserInfoService infoService = new UserInfoService();

        private void LogIn_Load(object sender, EventArgs e)
        {
            Txb_account.KeyDown += Txb_account_KeyDown;
            Txb_pwd.KeyDown += Txb_pwd_KeyDown;
#if DEBUG
            Txb_account.Text = "001";
            Txb_pwd.Text = "001";
            CheckUserInfo();
#endif

        }

        private void Txb_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CheckUserInfo();
        }

        private void Txb_account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Txb_pwd.Focus();
                Txb_pwd.SelectionStart = Txb_pwd.Text.Length;
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            CheckUserInfo();
        }

        public void CheckUserInfo()
        {
            string account = Txb_account.Text.Trim();
            string pwd = Txb_pwd.Text.Trim();
            if (account.Length == 0)
            {
                MetroMessageBox.Show(this, "请输入账号");
                return;
            }
            if (pwd.Length == 0)
            {
                MetroMessageBox.Show(this, "请输入密码");
                return;
            }

            UserInfo user = infoService.GetUserInfoByAccount(account, pwd);
            if (user == null || user.id == 0)
            {
                MetroMessageBox.Show(this,"登陆失败");
                return;
            }
            else
            {
                SYSUser.id = user.id;
                SYSUser.Name = user.Uname;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

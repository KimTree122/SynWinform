using DevComponents.DotNetBar;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CS.Models.BaseInfo;
using System.Windows.Forms;
using CS.BLL.BaseInfo;

namespace CS.UI
{
    public partial class BaseTabFrom : Office2007Form
    {
        public BaseTabFrom()
        {
            InitializeComponent();
        }

        private List<Authority> GetOperAuthByTag(int formtag)
        {
            AuthorityService service = new AuthorityService();
            return service.GetOperAuthbyTag(formtag,"编辑权限");
        }

        public void LoadUserAuth()
        {
            if (this.Tag == null) return;
            int formtag = (int)this.Tag;
            List<Authority> oper = GetOperAuthByTag(formtag);

            SetControl(oper, formtag, false);

            SetControl(SYSUser.OperAuth, formtag, true);
        }

        private void SetControl(List<Authority> authorities , int parentid,bool enable)
        {
            if (authorities == null) return;
            if (authorities.Count == 0) return;
            
            foreach (var au in authorities)
            {
                if (au.ParentID == parentid)
                {
                    Control[] cons = this.Controls.Find(au.Path,true);
                    if (cons.Count()> 0)
                    {
                        cons[0].Enabled = enable;
                    }
                }
            }
        }

        public void ShowTipsMessageBox(string msg )
        {
            MetroMessageBox.Show(this, msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult ShowWarningMessageBox(string msg)
        {
            return MetroMessageBox.Show(this, msg, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public void ShowErrorMessageBox(string msg)
        {
            MetroMessageBox.Show(this, msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowQuestionMessageBox(string msg)
        {
            return MetroMessageBox.Show(this, msg, "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void BaseTabFrom_Shown(object sender, EventArgs e)
        {
            LoadUserAuth();
        }
    }
}

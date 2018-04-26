using DevComponents.DotNetBar;
using MetroFramework;
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
    public partial class BaseTabFrom : Office2007RibbonForm
    {
        public BaseTabFrom()
        {
            InitializeComponent();
        }

        public void ShowTipsMessageBox(string msg )
        {
            MetroMessageBox.Show(this, msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowWarningMessageBox(string msg)
        {
            MetroMessageBox.Show(this, msg, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowErrorMessageBox(string msg)
        {
            MetroMessageBox.Show(this, msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowQuestionMessageBox(string msg)
        {
            return MetroMessageBox.Show(this, msg, "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}

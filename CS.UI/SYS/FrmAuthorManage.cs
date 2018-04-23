using CS.Models.BaseInfo;
using DevComponents.DotNetBar;
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
    public partial class FrmAuthorManage : BaseTabFrom
    {
        public FrmAuthorManage()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            Authority authority = new Authority();
            
        }

    }
}

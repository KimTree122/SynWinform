using CS.BLL.BaseInfo;
using CS.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.UI
{
    public class ComboBoxBind
    {
        private static BaseInfoService baseInfo = new BaseInfoService();

        public static void ComboBoxData(ComboBox box, string type)
        {
            List<Sysdic> sysdics = baseInfo.GetDicByType("权限类型");
            box.DataSource = sysdics;
            box.DisplayMember = "Dicval";
            box.ValueMember = "id";
        }
    }
}

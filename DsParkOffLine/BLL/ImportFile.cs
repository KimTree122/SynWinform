using DsParkOffLine.ADO;
using DsParkOffLine.Npoi;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DsParkOffLine.BLL
{
    public class ImportFile
    {
        private static string[] ImExColName = { "姓名","身份证","学员编号","教练代码","报名日期","性别","技能证日期","科一","科二","科三","科四"};
        internal static void ImoprtExcel(string str, ParkStudent parkStudent)
        {
            DataTable dt =  NPOIHelper.Import(str);

            int CorCount = 0;
            foreach (string col in ImExColName)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    if (dc.ColumnName == col)
                    {
                        CorCount++;
                    }
                }
            }
            if (CorCount  != ImExColName.Count())
            {
                MetroMessageBox.Show(parkStudent, "表格名称不匹配", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<ImportExcelCls>  ieclist = new List<ImportExcelCls>();
            foreach (DataRow dr in dt.Rows)
            {
                ImportExcelCls tec = new ImportExcelCls
                {
                    name = dr["姓名"].ToString(),
                    dsid = dr["身份证"].ToString(),
                    dsno = dr["学员编号"].ToString(),
                    trainercode = dr["教练代码"].ToString(),
                    checkin = dr["报名日期"].ToString(),
                    sex = dr["性别"].ToString(),
                    skilldate = dr["技能证日期"].ToString(),
                    ky = dr["科一"].ToString(),
                    ke = dr["科二"].ToString(),
                    ks = dr["科三"].ToString(),
                    kms = dr["科四"].ToString()
                };
                ieclist.Add(tec);
            }

            DataCenter datac = new DataCenter();
            datac.InsOrUpdataDBHistory(ieclist);
            MetroMessageBox.Show(parkStudent, "导入完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

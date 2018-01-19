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
        private static string[] ImExColName = { "日期","教练","教练代码","学员编号","类型","姓名","合格","不合格","缺考"};
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
            }

            List<ImportExcelCls>  ieclist = new List<ImportExcelCls>();
            foreach (DataRow dr in dt.Rows)
            {
                ImportExcelCls tec = new ImportExcelCls
                {
                    date = dr["日期"].ToString(),
                    type = dr["类型"].ToString(),
                    dsno = dr["学员编号"].ToString(),
                    name = dr["姓名"].ToString(),
                    trainer = dr["教练"].ToString(),
                    traincode = dr["教练代码"].ToString(),
                    pass = dr["合格"].ToString(),
                    unpass = dr["不合格"].ToString(),
                    untest = dr["缺考"].ToString()
                };

                ieclist.Add(tec);
            }

            List<DsHistory> dhlist = new List<DsHistory>();
            foreach (var iec in ieclist)
            {
                if (iec.pass == "TRUE")
                {
                    DsHistory dh = new DsHistory { id = iec.dsno, form = iec.type, oper = "合格", rec = iec.date };
                    dhlist.Add(dh);
                }
            }

            DataCenter datac = new DataCenter();
            datac.InsDBHistory(dhlist);
            MetroMessageBox.Show(parkStudent, "导入完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

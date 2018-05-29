using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CS.UI.ReportReource
{
    public class PrintFileHelper
    {
        public void PrintFile(string filepath)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            //不现实调用程序窗口,但是对于某些应用无效
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            //采用操作系统自动识别的模式
            p.StartInfo.UseShellExecute = true;

            //要打印的文件路径，可以是WORD,EXCEL,PDF,TXT等等
            p.StartInfo.FileName = filepath;

            //指定执行的动作，是打印，即print，打开是 open
            p.StartInfo.Verb = "print";

            //开始
            p.Start();
        }

        public void PrintFile(string filepath, string printer)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            //不现实调用程序窗口,但是对于某些应用无效
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            //采用操作系统自动识别的模式
            p.StartInfo.UseShellExecute = true;

            //要打印的文件路径
            p.StartInfo.FileName = filepath;

            //指定执行的动作，是打印，即print，打开是 open
            p.StartInfo.Verb = "print";

            //获取当前默认打印机

            //string defaultPrinter = GetDefaultPrinter();

            //将指定的打印机设为默认打印机
            //SetDefaultPrinter(printer);

            //开始打印
            p.Start();

            //等待十秒
            p.WaitForExit(10000);

            //将默认打印机还原
            //SetDefaultPrinter(defaultPrinter);
        }

        /*
        public void PrintOffice()
        {
            //要打印的文件路径
            object wordFile = @"d:\a.doc";

            object oMissing = Missing.Value;

            //自定义object类型的布尔值
            object oTrue = true;
            object oFalse = false;

            object doNotSaveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;

            //定义WORD Application相关
            Word.Application appWord = new Word.Application();

            //WORD程序不可见
            appWord.Visible = false;
            //不弹出警告框
            appWord.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone;

            //先保存默认的打印机
            string defaultPrinter = appWord.ActivePrinter;

            //打开要打印的文件
            Word.Document doc = appWord.Documents.Open(
                ref wordFile,
                ref oMissing,
                ref oTrue,
                ref oFalse,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing);

            //设置指定的打印机
            appWord.ActivePrinter = "指定打印机的名字";

            //打印
            doc.PrintOut(
                ref oTrue, //此处为true,表示后台打印
                ref oFalse,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing,
                ref oMissing
                );

            //打印完关闭WORD文件
            doc.Close(ref doNotSaveChanges, ref oMissing, ref oMissing);

            //还原原来的默认打印机
            appWord.ActivePrinter = defaultPrinter;

            //退出WORD程序
            appWord.Quit(ref oMissing, ref oMissing, ref oMissing);

            doc = null;
            appWord = null;
        }
        */
    }
}

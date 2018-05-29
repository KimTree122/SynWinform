using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.UI.ReportReource
{
    /// <summary>  
    /// 文件打印方法  
    /// </summary>  
    public class PrintService
    {
        public PrintService()
        {
            //将事件处理函数添加到PrintDocument的PrintPage中  
            this.docToPrint.PrintPage += new PrintPageEventHandler(docToPrint_PrintPage);
        }

        // Declare the PrintDocument object.  
        private string streamType;
        private Stream streamToPrint;
        private PrintDocument docToPrint = new PrintDocument();//创建一个PrintDocument的实例  

        // This method will set properties on the PrintDialog object and  
        // then display the dialog.  
        public void StartPrint(Stream streamToPrint, string streamType)
        {
            this.streamToPrint = streamToPrint;
            this.streamType = streamType;
            PrintDialog printDialog = new PrintDialog();//创建一个PrintDialog的实例  
            printDialog.AllowSomePages = true;
            printDialog.ShowHelp = true;
            // Set the Document property to the PrintDocument for  
            // which the PrintPage Event has been handled. To display the  
            // dialog, either this property or the PrinterSettings property  
            // must be set  
            printDialog.Document = docToPrint;//把PrintDialog的Document属性设为上面配置好的PrintDocument的实例  
            DialogResult result = printDialog.ShowDialog();//调用PrintDialog的ShowDialog函数显示打印对话框  
            // If the result is OK then print the document.  
            if (result == DialogResult.OK)
            {
                docToPrint.Print();//开始打印  
            }
        }

        // The PrintDialog will print the document  
        // by handling the document’s PrintPage event.  
        private void docToPrint_PrintPage(object sender,
        System.Drawing.Printing.PrintPageEventArgs e)//设置打印机开始打印的事件处理函数  
        {
            // Insert code to render the page here.  
            // This code will be called when the control is drawn.  
            // The following code will render a simple  
            // message on the printed document  
            switch (this.streamType)
            {
                case "txt":
                    string text = null;
                    System.Drawing.Font printFont = new System.Drawing.Font
                    ("Arial", 35, System.Drawing.FontStyle.Regular);
                    // Draw the content.  
                    System.IO.StreamReader streamReader = new StreamReader(this.streamToPrint);
                    text = streamReader.ReadToEnd();
                    e.Graphics.DrawString(text, printFont, System.Drawing.Brushes.Black, e.MarginBounds.X, e.MarginBounds.Y);
                    break;
                case "image":
                    System.Drawing.Image image = System.Drawing.Image.FromStream(this.streamToPrint);
                    int x = e.MarginBounds.X;
                    int y = e.MarginBounds.Y;
                    int width = image.Width;
                    int height = image.Height;
                    if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
                    {
                        width = e.MarginBounds.Width;
                        height = image.Height * e.MarginBounds.Width / image.Width;
                    }
                    else
                    {
                        height = e.MarginBounds.Height;
                        width = image.Width * e.MarginBounds.Height / image.Height;
                    }
                    System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
                    e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
                    break;
                default:
                    break;
            }
        }
    }
}

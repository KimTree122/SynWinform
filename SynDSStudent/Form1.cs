using SynDSStudent.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynDSStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printfile();
        }

        private Bitmap showBitmap = null;
        private Bitmap srcBitmap = null;

        private void button2_Click(object sender, EventArgs e)
        {
            NetPOSPrinter np = new NetPOSPrinter(txtIP.Text.Trim());
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = @"Bitmap文件(*.bmp)|*.bmp|Jpeg文件(*.jpg)|*.jpg|所有合适文件(*.bmp,*.jpg)|*.bmp;*.jpg";

            openFileDialog.FilterIndex = 3;

            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())

            {

                srcBitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);

                showBitmap = srcBitmap;

                np.PrintPic(srcBitmap);



            }


        }

        private void printfile()
        {
            Process pro = new Process();
            pro.StartInfo.FileName = @"C:\gitweb\test.txt";//文件路径
            pro.StartInfo.CreateNoWindow = true;
            pro.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pro.StartInfo.Verb = "Print";
            pro.Start();
        }

        private void NetPrint()
        {
            Socket s = null;

            IPEndPoint hostEndPoint = new IPEndPoint(IPAddress.Parse(txtIP.Text.ToString().Trim()), Convert.ToInt32("9100"));

            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            s.Connect(hostEndPoint);

            if (!s.Connected)

            {

                MessageBox.Show("Not Connected");

            }

            else

            {

                StreamReader sr1 = new StreamReader(@"C:\gitweb\test.txt", Encoding.UTF8);

                string strlabel = sr1.ReadToEnd();

                sr1.Close();

                Byte[] data = Encoding.UTF8.GetBytes(strlabel);

                s.Send(data, data.Length, 0);       //发送数据文件

                if (s.Connected)

                    s.Close();

            }

            System.Threading.Thread.Sleep(1500);
        }
    }
}

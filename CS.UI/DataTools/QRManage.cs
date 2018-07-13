using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;

namespace CS.UI.DataTools
{
    public class QRManage
    {
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="strMessage">二维码信息</param>
        /// <param name="width">宽</param>
        /// <param name="height">高</param>
        /// <returns></returns>
        public static Bitmap GetQRCodeByZXingNet(string strMessage, Int32 width, Int32 height)
        {
            Bitmap result = null;
            try
            {
                BarcodeWriter barCodeWriter = new BarcodeWriter();
                barCodeWriter.Format = BarcodeFormat.QR_CODE;
                barCodeWriter.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
                barCodeWriter.Options.Hints.Add(EncodeHintType.ERROR_CORRECTION, ZXing.QrCode.Internal.ErrorCorrectionLevel.H);
                barCodeWriter.Options.Height = height;
                barCodeWriter.Options.Width = width;
                barCodeWriter.Options.Margin = 0;
                ZXing.Common.BitMatrix bm = barCodeWriter.Encode(strMessage);
                result = barCodeWriter.Write(bm);
            }
            catch (Exception)
            {
                //异常输出
            }
            return result;
        }


        /// <summary>
        /// 生成带Logo的二维码
        /// </summary>
        /// <param name="text"></param>
        public static Bitmap GetQRCodeByZXingNet(string strMessage,string picpath)
        {
            //Logo 图片
            Bitmap logo = new Bitmap(picpath);
            //构造二维码写码器
            MultiFormatWriter writer = new MultiFormatWriter();
            Dictionary<EncodeHintType, object> hint = new Dictionary<EncodeHintType, object>();
            hint.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
            hint.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

            //生成二维码 
            BitMatrix bm = writer.encode(strMessage, BarcodeFormat.QR_CODE, 300, 300, hint);
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            Bitmap map = barcodeWriter.Write(bm);


            //获取二维码实际尺寸（去掉二维码两边空白后的实际尺寸）
            int[] rectangle = bm.getEnclosingRectangle();

            //计算插入图片的大小和位置
            int middleW = Math.Min((int)(rectangle[2] / 3.5), logo.Width);
            int middleH = Math.Min((int)(rectangle[3] / 3.5), logo.Height);
            int middleL = (map.Width - middleW) / 2;
            int middleT = (map.Height - middleH) / 2;

            //将img转换成bmp格式，否则后面无法创建Graphics对象
            Bitmap bmpimg = new Bitmap(map.Width, map.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmpimg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.DrawImage(map, 0, 0);
            }
            //将二维码插入图片
            Graphics myGraphic = Graphics.FromImage(bmpimg);
            //白底
            myGraphic.FillRectangle(Brushes.White, middleL, middleT, middleW, middleH);
            myGraphic.DrawImage(logo, middleL, middleT, middleW, middleH);

            //保存成图片
            //bmpimg.Save(@"H:\桌面\截图\generate3.png", ImageFormat.Png);
            return bmpimg;
        }


        /// <summary>
        /// 解码二维码
        /// </summary>
        /// <param name="barcodeBitmap">待解码的二维码图片</param>
        /// <returns>扫码结果</returns>
        public static string DecodeQrCode(Bitmap barcodeBitmap)
        {
            BarcodeReader reader = new BarcodeReader();
            reader.Options.CharacterSet = "UTF-8";
            var result = reader.Decode(barcodeBitmap);
            return (result == null) ? "" : result.Text;
        }
    }
}

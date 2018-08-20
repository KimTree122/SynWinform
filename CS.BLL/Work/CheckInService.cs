using CS.DAL;
using KNDBsys.Model;
using KNDBsys.Model.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL.Work
{
    public class CheckInService:PostService<CheckInDT,CheckInMT>
    {

        public string GetQrnumber(int userid)
        {
            string url = KNDBsysUrl.WorkUrl.CheckInBLL.GetQRnumber;
            HttpTools tools = new HttpTools();
            tools.AddParam("userid", userid).Build();
            return GetMsg(url, tools);
        }

        public PostData<CheckInDT, CheckInMT> GetCheckInDTMT(string checkinmtid)
        {
            string url = KNDBsysUrl.WorkUrl.CheckInBLL.GetCheckInByMTid;
            HttpTools tools = new HttpTools();
            tools.AddParam("checkinmtid", checkinmtid.ToInt()).Build();
            return GetPostData(url,tools);
        }


        public int AddCheckInMT(CheckInMT mT)
        {
            string url = KNDBsysUrl.WorkUrl.CheckInBLL.AddCheckInMT;
            HttpTools tools = new HttpTools();
            tools.AddParam("checkinmt", DataSwitch.DataToJson(mT)).Build(); ;
            return GetMsg(url, tools).ToInt();
        }

        public bool UpdateCheckInMT(CheckInMT mT)
        {
            string url = KNDBsysUrl.WorkUrl.CheckInBLL.UpdateCheckInMT;
            HttpTools tools = new HttpTools();
            tools.AddParam("checkinmt", DataSwitch.DataToJson(mT)).Build(); ;
            return GetMsg(url, tools).ToInt() > 0;
        }

        public int AddCheckInDT(CheckInDT dT)
        {
            string url = KNDBsysUrl.WorkUrl.CheckInBLL.AddCheckInDT;
            HttpTools tools = new HttpTools();
            tools.AddParam("checkindt", DataSwitch.DataToJson(dT)).Build(); ;
            return GetMsg(url, tools).ToInt();
        }

        public int UpdateCheckInDT(CheckInDT dT)
        {
            string url = KNDBsysUrl.WorkUrl.CheckInBLL.UpdateCheckInDT;
            HttpTools tools = new HttpTools();
            tools.AddParam("checkindt", DataSwitch.DataToJson(dT)).Build(); ;
            return GetMsg(url, tools).ToInt();
        }

        public int GetCustomidByQR(string qrcode)
        {
            string url = KNDBsysUrl.WorkUrl.CheckInBLL.GetCustomidByQR;
            HttpTools tools = new HttpTools();
            tools.AddParam("qrcode", qrcode).Build(); ;
            return GetMsg(url, tools).ToInt();
        }
    }
}

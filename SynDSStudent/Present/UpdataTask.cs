using SynDSStudent.SQLiteADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SynDSStudent.Present
{
    public class UpdataTask
    {
        private HttpConnect hc;
        private DataOper dop;
        public delegate void mpsValue(int value);

        public UpdataTask() 
        {
            hc = new HttpConnect();
            dop = new DataOper(); 
        }

        public void UpdateAllStuData()
        {

            Posts p = hc.GetAllStu();
            DsPostVerid dpv = hc.GetSerStuVer();
            List<DSstu> dslist = DataSwitch.JsonToList<DSstu>(p.Jsons);
            dop.InsandDelStuData(dslist);
            dop.UpdataVer(dpv,0);
        }

        public void UploadAllStu(mpsValue vm)
        {
            new Thread( UpdateAllStuData).Start();
        }

        public void UpdataDiffStuData()
        {
            DsPostVerid ldpv = dop.GetLocalDPV("0");
            DsPostVerid sdpv = hc.GetSerStuVer();
            List<Posts> plist = hc.StuDiff(sdpv, ldpv);
            List<DSstu> dslist = new List<DSstu>();
            foreach (var p in plist)
            {
                List<DSstu> dl = DataSwitch.JsonToList<DSstu>(p.Jsons);
                dslist.AddRange(dl);
            }
            dop.InsandDelStuData(dslist);
            dop.UpdataVer(sdpv,0);
        }


        public void UpdataHisData()
        {
            DsPostVerid ldpv = dop.GetLocalDPV("1");
            DsPostVerid sdpv = hc.GetSerHisVer();
            List<Posts> plist = hc.HisData(sdpv, ldpv);
            List<DsHistory> dshlist = new List<DsHistory>();
            foreach (var p in plist)
            {
                List<DsHistory> dl = DataSwitch.JsonToList<DsHistory>(p.Jsons);
                if (dl == null) continue;
                dshlist.AddRange(dl);
            }
            dop.InsertHisData(dshlist);
            dop.UpdataVer(sdpv, 1);
        }


    }
}

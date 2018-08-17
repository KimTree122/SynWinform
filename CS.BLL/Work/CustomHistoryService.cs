using CS.DAL;
using CS.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL.Work
{
    public class CustomHistoryService : PostService<CustomHistoryVM, CustomHistoryVM>
    {
        public List<CustomHistoryVM> GetCustomHistoryVMs(int customid, int stauts =0 )
        {
            string url = KNDBsysUrl.WorkUrl.CheckInBLL.GetCustomHistory;
            HttpTools tools = new HttpTools();
            tools.AddParam("customid", customid).AddParam("stauts", stauts).Build(); ;
            return GetList(url, tools);
        }
    }
}

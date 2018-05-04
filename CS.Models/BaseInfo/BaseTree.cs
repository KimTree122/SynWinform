using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Models.BaseInfo
{
    public class BaseTreetest
    {
        public int id { get; set; }
        public int fid { get; set; }
    }



    public class AuthTree : BaseTreetest
    {

        public string AuthName { get; set; }
    }

    public class GoodsTree : BaseTreetest
    {

        public string GoodsType { get; set; }
    }
}

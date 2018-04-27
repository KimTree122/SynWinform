using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL
{
    public static class DataChange
    {
        public static int ToInt(this string t)
        {
            if (string.IsNullOrWhiteSpace(t)) return 0;
            int.TryParse(t, out int i);
            return i;
        }
    }
}

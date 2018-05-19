using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpgradeFile
{
    public class FileLoadModel
    {

    }

    public class PostData<L, E>
    {
        public int MCount { get; set; }
        public List<L> DList { get; set; }
        public string Msg { get; set; }
        public E Entity { get; set; }
    }
}

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

    public partial class SysVer
    {
        public SysVer()
        {


        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public int id { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string sysver { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string upgradedate { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string filelist { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string note { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string programtype { get; set; }

    }

}

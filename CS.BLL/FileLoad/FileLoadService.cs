using CS.DAL;
using CS.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.BLL.FileLoad
{
    public class FileLoadService:PostService<FileLoadVM, FileLoadVM>
    {
        public delegate void Uploadstate(int type, string msg);
        private Uploadstate uploadstate;

        public FileLoadService(Uploadstate us)
        {
            uploadstate = us;
        }

        public string UpLoadFile(List<FileLoadVM> files)
        {



            return "";
        }
    }
}

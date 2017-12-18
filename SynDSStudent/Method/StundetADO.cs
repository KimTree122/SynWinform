using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace SynDSStudent.Method
{
    public class StundetADO
    {
        public SQLiteConnection conn;
        public SQLiteCommand cmd; 
        public StundetADO(InitSetting init)
        {
            conn = init.conn;
            cmd = init.cmd;
        }




    }
}

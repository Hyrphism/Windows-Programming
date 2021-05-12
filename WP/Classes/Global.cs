using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP.Classes
{
    class Global
    {
        public static int GlobalUserID { get; private set; }

        public static void SetGlobalUserID(int id)
        {
            GlobalUserID = id;
        }
    }
}

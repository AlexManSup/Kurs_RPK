using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Kurs_RPK
{
    class ConnectionStr
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Kurs_RPK.Properties.Settings.ConnectionString"].ConnectionString;
            }
        }
    }
}

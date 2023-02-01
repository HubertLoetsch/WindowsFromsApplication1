using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics.Metrics;

namespace WindowsFromsApplication1
{
     class ProjectConnection
    {
        public static SqlConnection conn = null;

            public void Connection_Today()
            {
            conn = new SqlConnection("Data Source = HUBSI\\SQLEXPRESS; Initial Catalog = master; Integrated Security = True");//(Server)"
            conn.Open();

            }
    }
}

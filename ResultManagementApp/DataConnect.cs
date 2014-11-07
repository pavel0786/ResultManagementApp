using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultManagementApp
{
    class DataConnect
    {
        //public static string ConnectionString = @"server=BITM-PC02\SQLEXPRESS;database=StudentManagement;integrated security=true";

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["StudentManagementConnectionString"].ConnectionString;
    }
}

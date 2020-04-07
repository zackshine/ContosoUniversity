using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Utility
{
    public static class ConnectionString
    {
        private static string cName = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=ContosoUniversity2;Integrated Security=SSPI;";
        public static string CName
        {
            get => cName;
        }
    }
}
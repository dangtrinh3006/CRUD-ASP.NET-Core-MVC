using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales_Order.Utility
{
    public static class ConnectionStringg
    {
        private static string cName = "Data Source=DANGTRINH;Initial Catalog=SalesOrderDB;Integrated Security=True";
        public static string CName { get => cName; } 
    }
}

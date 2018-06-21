using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OracleDbCrawler;
using Newtonsoft.Json;
using System.IO;

namespace FunctionalTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var tables = DbConnection.CreateConnectionString("data source=wwwtst;user id=plm;password=testuser1;").GetTable("sys","DbTable", "1=1");
            String tablescontent= JsonConvert.SerializeObject(tables);
            String di = AppDomain.CurrentDomain.BaseDirectory;
        }

        
    }
}

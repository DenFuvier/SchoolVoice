using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SQLConnector
    {
        public string server = "localhost";
        public string userid = "root";
        public string password = "vertrigo";
        public string database = "schoolbase";

        public string GetConnect()
        {
            return $"server={server};userid={userid};password={password};database={database}";
        }


    }
}

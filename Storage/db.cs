using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Storage
{
   
   public class db
    {
        private static MySqlConnection con = new MySqlConnection();
        private static MySqlCommand ccmd;
        public db(string cn, string cmd)
        {
            con.ConnectionString = cn;
            ccmd.CommandText = cmd;
        }
    }
}

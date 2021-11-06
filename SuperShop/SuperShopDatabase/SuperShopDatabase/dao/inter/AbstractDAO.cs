using MySql.Data.MySqlClient;
using SuperShopDatabase.config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SuperShopDatabase.dao.inter
{
    class AbstractDAO
    {
        private static Config config = new Config();
        private static Connection connection = config.GetConnection();

        public static MySqlConnection Connect ()
        {
            var con = new MySqlConnection(connection.GenerateString());
            con.Open();
            return con;
        }
    }
}

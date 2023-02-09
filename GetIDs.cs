using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordEditDNF
{
    internal class GetIDs
    {

        public static int idLength;
        public static void Start()
        {
            string conStr = "server=localhost;user=root;database=Raters;password=1009";
            MySqlConnection sqlCon = new MySqlConnection(conStr);

            sqlCon.Open();

            MySqlCommand mySqlCommand = new MySqlCommand("select count(id) from data", sqlCon);
            string id = mySqlCommand.ExecuteScalar().ToString();
            idLength = Convert.ToInt32(id);

            sqlCon.Close();

        }
    }
}

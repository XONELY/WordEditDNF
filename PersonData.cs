using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WordEditDNF
{
    class PersonData
    {
        public Dictionary<string, string> info = new Dictionary<string, string>()
        {
            ["ID"] = "None",
            ["FULLNAME"] = "None",
            ["BIRTHDATE"] = "None",
            ["INN"] = "None",
            ["PASSPORT"] = "None",
            ["INITIALS"] = "None",
            ["INS_NUMBER"] = "None",
            ["INS_DATE_FROM"] = "None",
            ["INS_DATE_TO"] = "None",
            ["INS_AMOUNT"] = "None",
            ["INS_NAME"] = "None",
            ["PASS_ADR"] = "None",
            ["SNILS"] = "None",
        };

        public PersonData(int counter)
        {
            string[] keys = info.Keys.ToArray();
            string conStr = "server=localhost;user=root;database=Raters;password=1009";
            MySqlConnection sqlCon = new MySqlConnection(conStr);
            sqlCon.Open();
            MySqlCommand mySqlCommand = new MySqlCommand($"select * from data where id = {counter + 1}", sqlCon); //+1 так как в ID в БД отсчет от 1
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                {
                    info[keys[i]] = mySqlDataReader.GetString(i);

                }
            }

            sqlCon.Close();
        }
    }

}
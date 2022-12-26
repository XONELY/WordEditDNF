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
       static int counter = 0;
       private string Name;
       public string name { get { return Name; } set { Name = value; } }
        public Dictionary<string, string> info = new Dictionary<string, string>()
        {
            ["FULLNAME"] = "None",
            ["BIRTHDATE"] = "None",
            ["INN"] = "None",
            ["SNILS"] = "None",
            ["PASSPORT"] = "None",
            ["INITIALS"] = "None",
            ["INS_NUMBER"] = "None",
            ["INS_DATE_FROM"] = "None",
            ["INS_DATE_TO"] = "None",
            ["INS_AMOUNT"] = "None",
            ["INS_NAME"] = "None",
            ["PASS_ADR"] = "None",
        };

        public PersonData(string name)
        {
            this.name = name;
            
            Console.WriteLine($"Создан объект с именем: {name}, присвоен номер [{counter}].");
            counter++;
        }
    } 
}


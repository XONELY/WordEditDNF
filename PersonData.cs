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
       public string name;
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

        public PersonData(string Name)
        {
            name = Name;
            
            Console.WriteLine($"Создан объект с именем: {Name}, присвоен номер [{counter}].");
            counter++;
        }
    } 
}


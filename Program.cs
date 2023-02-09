using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using Microsoft.SqlServer.Server;

namespace WordEditDNF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                try
                {
                    GetIDs.Start();

                    string[] replaceFields =
                            {
                    "{ID}",
                    "{FULLNAME}",
                    "{BIRTHDATE}",
                    "{INN}",
                    "{PASSPORT}",
                    "{INITIALS}",
                    "{INS_NUMBER}",
                    "{INS_DATE_FROM}",
                    "{INS_DATE_TO}",
                    "{INS_AMOUNT}",
                    "{INS_NAME}",
                    "{PASS_ADR}",
                    "{SNILS}",
                    };
                    Console.WriteLine("Укажите путь к директории с .docx файлами");
                    string wordfileDir = Console.ReadLine();
                    string[] wordFiles = Directory.GetFiles(wordfileDir);
                    Console.WriteLine("Укажите тип файлов");
                    string type = Console.ReadLine();

                    List<PersonData> personDatas = new List<PersonData>();
                    for (int i = 0; i < wordFiles.Length; i++)
                    {
                        personDatas.Add(new PersonData(i));
                    }

                    for (int i = 0; i < wordFiles.Count(); i++)
                    {
                        string[] replaceTo = personDatas[i].info.Values.ToArray();
                        Editor.Start(wordFiles[i], replaceFields, replaceTo, type);

                    }

                    repeat = false;
                    Console.ReadKey();

                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Неверно указана директория");

                }
            }
        }
    }
}
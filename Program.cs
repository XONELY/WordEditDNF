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
                    Console.WriteLine("Укажите путь к директории с данными");
                    string DataDir = Console.ReadLine();
                    Menu.Message("Чтение директории");
                    string[] allDataFiles = Directory.GetFiles(DataDir);
                    List<PersonData> persons = new List<PersonData>();
                    foreach (string DataFile in allDataFiles)
                    {
                        persons.Add(new PersonData(DataFile.Remove(0, 39).Trim(new char[] { '.', 'c', 's', 'v' }))); //ew
                    }

                    for (int i = 0; i < persons.Count; i++)
                    {
                        List<string> Data = LoadDataFile.Start(allDataFiles[i]);
                        Menu.Message($"Данные из ({allDataFiles[i]}) загружены.");
                        Menu.Message("Присвоение загруженных данных по ключу...");
                        string[] keys = persons[i].info.Keys.ToArray();
                        int counter = 0;
                        foreach (string key in keys)
                        {
                            persons[i].info[key] = Data[counter];
                            counter++;
                        }
                        Menu.Message($"Данные ({persons[i].name}) присвоены.");
                    }

                    string[] replaceFields =
                    {
                    "{FULLNAME}",
                    "{BIRTHDATE}",
                    "{INN}",
                    "{SNILS}",
                    "{PASSPORT}",
                    "{INITIALS}",
                    "{INS_NUMBER}",
                    "{INS_DATE_FROM}",
                    "{INS_DATE_TO}",
                    "{INS_AMOUNT}",
                    "{INS_NAME}",
                    "{PASS_ADR}",
                    };

                    Console.WriteLine("Укажите путь к директории с .docx файлами");
                    string wordfileDir = Console.ReadLine();
                    Menu.Message("Чтение директории");
                    string[] wordFiles = Directory.GetFiles(wordfileDir);
                    Console.WriteLine("Укажите тип файлов");
                    string type = Console.ReadLine();
                    for (int i = 0; i < wordFiles.Count(); i++)
                    {
                        string[] replaceTo = persons[i].info.Values.ToArray();
                        Editor.Start(wordFiles[i], replaceFields, replaceTo, type);
                        Console.WriteLine($"loaded {wordFiles[i]}");
                    }
                    Menu.Message("Готово.");
                    repeat = false;
                    Console.ReadKey();

                }
                catch (DirectoryNotFoundException)
                {
                    Menu.Message("Неверно указана директория");

                }
            }
        }
    }
}
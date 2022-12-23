using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordEditDNF
{
     class LoadDataFile
    {
        public static List<string> Start(string path)
        {
            Menu.Message($"Чтение файла {path}...");

            StreamReader loadedFile = new StreamReader(path);
            List<string> lines = new List<string>();
            string line = loadedFile.ReadLine();
                while (line != null)
                {
                lines.Add(line);
                line = loadedFile.ReadLine();
                }
            Menu.Message("Чтение завершено.");
            return lines;
        }
    }
}

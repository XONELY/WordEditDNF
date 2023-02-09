using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Document;

namespace WordEditDNF
{        
    
    class Editor
    {

        public static void Start(string dir, string[] ReplaceFields, string[] ReplaceTo, string type)
        {
            ComponentInfo.SetLicense("D02V-DHB9-YI9R-TMSV");

            DocumentModel document = DocumentModel.Load($"{dir}");
            for (int i = 0; i < ReplaceFields.Length; i++)
            {
                document.Content.Replace($"{ReplaceFields[i]}", $"{ReplaceTo[i]}");
                document.Content.Replace("{DATE}", DateTime.Today.ToString().Substring(0, 10));
            }
            document.Save($@"{dir.Substring(0, dir.Length - 4)}{type}.docx");
        }

    }
}

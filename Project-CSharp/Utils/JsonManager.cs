using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp
{
    class JsonManager
    {
        public static JObject GetJsonObjectFromFile(string filePath)
        {
            return JObject.Parse(File.ReadAllText(String.Concat(FileManager.GetProyectPath(), filePath)));
        }

        public static string GetJsonInStringFormat(string filePath)
        {
            return File.ReadAllText(String.Concat(FileManager.GetProyectPath(), filePath));
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp
{
    class FileManager
    {
        public static string GetProyectPath()
        {
            UriBuilder uri = new UriBuilder(Assembly.GetExecutingAssembly().CodeBase);
            return Path.GetDirectoryName(Uri.UnescapeDataString(uri.Path)).Replace("bin\\Debug", String.Empty);
        }
    }
}

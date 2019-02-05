using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskKitLTA.UWP
{
    public class FileAccess
    {
        public static string GetLocalFilePath(string FileName)
        {
            string path = System.Environment.GetFolderPath(
                System.Environment.SpecialFolder.Personal
                );
            return System.IO.Path.Combine(path, FileName);
        }
    }
}

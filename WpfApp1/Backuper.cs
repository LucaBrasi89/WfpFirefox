using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace ZipService
{
    class Backuper
    {
        public static void doBackup()
        {
            string profileDir = "xuhnyq1s.default-release";

            string appData = Environment.GetEnvironmentVariable("APPDATA");
            string path = Path.Combine(appData, @"Mozilla\Firefox\Profiles\");

            string source = Path.Combine(path, profileDir);
            string dest = Path.Combine(path, $"{profileDir}.zip");

            try
            {
                ZipFile.CreateFromDirectory(source, dest);
            }
            catch (IOException e)
            {
                throw new System.IO.IOException();
            }



            }
    }
}

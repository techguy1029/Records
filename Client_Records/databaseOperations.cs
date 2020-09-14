using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Records
{
    public class databaseOperations
    {
        public static int createDatabaseFile()
        {
            string databasePath = "C:\\ProgramData\\Records\\recordsDatabase.mdf";
            Directory.CreateDirectory(Path.GetDirectoryName(databasePath));
            File.Create(databasePath);
            if (File.Exists(databasePath))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibility
{
    public class Persistance
    {
        public void Save(Journal j, string fileName, bool overwrite = false)
        {
            if(overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, ToString());
            }
        }

        public static Journal Load(string filename)
        {
            return null;
        }

        public void Load(Uri uri)
        {

        }
    }
}

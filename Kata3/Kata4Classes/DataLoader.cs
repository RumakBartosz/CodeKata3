using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata3.Kata4Classes
{
    public class DataLoader
    {
        public DataLoader(string Path)
        {
            this.Path = Path;
        }

        //public const int WORDSINLINE = 17;
        readonly string Path;

        public String[] LoadFileToStringAndTokenize()
        {
            String[] FileContent;

            FileContent = File.ReadAllLines(Path);


            return FileContent;
        }


    }
}

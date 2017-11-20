using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_and_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);

        }
    }
}

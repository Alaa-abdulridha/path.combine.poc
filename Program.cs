using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Download(@"alaa.txt"));
            Console.ReadLine();
        }

        public static String Download(string fileName)
        {
            //fileName = Path.GetFileName(fileName);
            fileName = Path.Combine(Path.GetTempPath(), fileName);
            bool resultx = System.IO.File.Exists(fileName);
            return resultx.ToString() + ", file: " + fileName;
        }
    }
}

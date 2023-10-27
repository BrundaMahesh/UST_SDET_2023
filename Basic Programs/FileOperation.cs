using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class FileOperation
    {
        public void CreateFile()
        {
            FileInfo fileInfo = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            using StreamWriter streamWriter=fileInfo.CreateText();
            Console.WriteLine("File has been created");

            streamWriter.WriteLine("Welcome");
            streamWriter.WriteLine("Hello");
            streamWriter.WriteLine("How u doing?");

        }
    }
}

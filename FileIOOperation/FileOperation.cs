using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    public class FileOperation
    {
        public static void FileExist()
        {
            string filePath = @"C:\GetRepositry\file_IO\FileIOOperation\Operation.txt";
            if (File.Exists(filePath))
                Console.WriteLine("File Path Exists");
            else
                Console.WriteLine("File Path Doesnt Exists");
        }
    }
}

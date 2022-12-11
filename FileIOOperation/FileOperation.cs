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
        public static void ReadAllLines()
        {
            string filePath = @"C:\GetRepositry\file_IO\FileIOOperation\Operation.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (var data in lines)
            {
                Console.WriteLine(data);
            }
        }
        public static void ReadAllText()
        {
            string filePath = @"C:\GetRepositry\file_IO\FileIOOperation\Operation.txt";
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
        public static void CopyFile()
        {
            string filePath = @"C:\GetRepositry\file_IO\FileIOOperation\Operation.txt";
            string destinationFilePath = @"C:\GetRepositry\file_IO\FileIOOperation\Destination.txt";
            File.Copy(filePath, destinationFilePath, true);
        }
        public static void DeleteFile()
        {
            string destinationFilePath = @"C:\GetRepositry\file_IO\FileIOOperation\Destination.txt";
            File.Delete(destinationFilePath);
        }
        public static void ReadFromStreamReader()
        {
            string filePath = @"C:\GetRepositry\file_IO\FileIOOperation\Operation.txt";
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}


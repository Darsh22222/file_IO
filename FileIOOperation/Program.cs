﻿namespace FileIOOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to file operation");
            Console.WriteLine("Select Below Option");
            bool choice = true;
            while (choice)
            {
                Console.WriteLine(" 1. Check Files Exists or Not\n 2. Read All Lines\n3. Read Text\n4.Copy File\n5.Deleting File" +
                    "\n6.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FileOperation.FileExist();
                        break;
                    case 2:
                        FileOperation.ReadAllLines();
                        break;
                    case 3:
                        FileOperation.ReadAllText();
                        break;
                    case 4:
                        FileOperation.CopyFile();
                        Console.WriteLine("File Copied Successfully");
                        break;
                    case 5:
                        FileOperation.DeleteFile();
                        Console.WriteLine("File Deleted Successfully");
                        break;
                    default:
                        choice = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}

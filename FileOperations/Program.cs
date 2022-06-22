using System;
using System.IO;

namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "This is original value";
            MethodByRef(ref value);
            Console.WriteLine(value);
            MethodByVal(value);
            Console.WriteLine(value);
            //FileOperations.WriteFile("Writing line from Program.cs");
            //FileOperations.ReadFile();
            //FileOperations.FileInfo();
            //FileOperations.ListDiskDrives();
            //FileOperations.ListSubFolders();
            //FileOperations.ListFiles();
        }

        static void MethodByRef(ref string value)
        {
            value = "The value is updated by ref method.";
        }

        static void MethodByVal(string value)
        {
            value = "The value is updated by value method.";
        }
    }

    public static class FileOperations
    {
        public static void ReadFile()
        {
            StreamReader reader = new StreamReader("files\\TextFile.txt");
            try
            {
                do
                {
                    Console.WriteLine(reader.ReadLine());
                }
                while (reader.Peek() != -1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                reader.Close();
            }
        }

        public static void WriteFile(string line)
        {
            StreamWriter writer = new StreamWriter("files\\TextFile.txt");
            writer.WriteLine(line);
            writer.Close();
        }

        public static void FileInfo()
        {
            FileInfo FileProps = new FileInfo("files\\TextFile.txt");
            Console.WriteLine("File Name = " + FileProps.FullName);
            Console.WriteLine("Creation Time = " + FileProps.CreationTime);
            Console.WriteLine("Last Access Time = " + FileProps.LastAccessTime);
            Console.WriteLine("Last Write TIme = " + FileProps.LastWriteTime);
            Console.WriteLine("Size = " + FileProps.Length);
        }

        public static void ListDiskDrives()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                Console.WriteLine(drive);
            }
        }

        public static void ListSubFolders()
        {
            string[] dirs = Directory.GetDirectories(".\\");
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
        }

        public static void ListFiles()
        {
            string[] files = Directory.GetFiles("files");
            foreach (string i in files)
            {
                Console.WriteLine(i);
            }
        }
    }
}

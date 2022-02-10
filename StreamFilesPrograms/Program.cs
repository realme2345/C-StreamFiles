using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamFilesPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exit();
            //ReadFile();
            //CopyFile();
            //DeleteFile();
            //StreamReader();
            //StreamWriter();
            BinarySerialization.Serialisation();
            BinarySerialization.Deserialisation();
        }
        public static void Exit()//To know the File is Exist or not
        {
            string path = @"D:\git\C#StreamFiles\C-StreamFiles\StreamFilesPrograms\Sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File is present");
            }
            else
            {
                Console.WriteLine("File is not found");
            }
        }
        public static void ReadFile()//it is used to Read the files
        {
            string path = @"D:\git\C#StreamFiles\C-StreamFiles\StreamFilesPrograms\Sample.txt";
            string read = File.ReadAllText(path);
            Console.WriteLine(read);
            Console.ReadKey();
        }
        public static void CopyFile()//this method for copy the file from one file to another
        {
            string path = @"D:\git\C#StreamFiles\C-StreamFiles\StreamFilesPrograms\Sample.txt";
            string CopyPath = @"D:\git\C#StreamFiles\C-StreamFiles\StreamFilesPrograms\Sample1.txt";
            File.Copy(path, CopyPath);
            Console.ReadKey();
        }
        public static void DeleteFile()//this method for deleting the file
        {
            string CopyPath = @"D:\git\C#StreamFiles\C-StreamFiles\StreamFilesPrograms\Sample1.txt";
            File.Delete(CopyPath);
            Console.WriteLine("The file deleted suceefully");
            Console.ReadKey();
        }
        public static void StreamReader()//It is used to read the stream file
        {
            string path = @"D:\git\C#StreamFiles\C-StreamFiles\StreamFilesPrograms\Sample.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string line = "";
                if ((line=sr.ReadLine())!= null)
                {
                    Console.WriteLine(line);
                }
                Console.ReadKey();
            }
        }
        public static void StreamWriter()//It is used to write the files 
        {
            string path = @"D:\git\C#StreamFiles\C-StreamFiles\StreamFilesPrograms\Sample.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello Raja");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}

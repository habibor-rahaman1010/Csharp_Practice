using Microsoft.VisualBasic;
using System;
using System.Text;

namespace MorePracticeFileSystem
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            /*string path = "../../../text.txt";
            FileInfo file = new FileInfo(path);
            try
            {
                if (!file.Exists)
                {
                    file.Create();
                    Console.WriteLine("File has been created succesfully!");
                }
                else
                {
                    Console.WriteLine("The file is exist!");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            using Stream stream = file.Open(FileMode.Open);
            string message = "Hello developer how can i help you, i know you are the humple person";
            byte[] buffer = Encoding.UTF8.GetBytes(message);
           // stream.Write(buffer, 0, message.Length);
            stream.Flush();


            //for reading the file
            byte[] outByte = new byte[file.Length];
            int count = stream.Read(outByte, 0, (int)file.Length);
            string result = Encoding.UTF8.GetString(outByte);
            Console.WriteLine(result);
            Console.WriteLine($"Total File Text Length: {count}");*/

            DirectoryInfo currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            string path = Path.Combine(currentDirectory.Parent.Parent.Parent.FullName, "Temp");
            
            Directory.CreateDirectory(path);
        }
    }
}

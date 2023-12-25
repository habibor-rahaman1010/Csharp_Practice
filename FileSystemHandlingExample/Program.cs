using System;
using System.IO;
using System.Text;
namespace FileSystemHandlingExample
{
    public class Program
    {
        public static void Main(string[] args) {

            //Here use sattic File class.
            try
            {
                if (!File.Exists("../../../Example/hello.txt"))
                {
                    File.Create("../../../Example/hello.txt");
                    Console.WriteLine("File created!");
                }
                else
                {
                    Console.WriteLine("This file has been exits");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //Here use FileInfo class 

            try
            {
                string path = "../../../Example/information.txt";
                FileInfo file = new FileInfo(path);
                if (!file.Exists)
                {
                    file.Create();
                    Console.WriteLine("File created");
                }
                else
                {
                    Console.WriteLine("This file has been already exisit");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }


            //write operation in a text file...

            string path2 = "../../../Example/information.txt";
            FileInfo file2 = new FileInfo(path2);

            using Stream stream = file2.Open(FileMode.Open);
            string message = "This is our planet";
            string message2 = " Hello programmer how can i help you!";
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream.Write(buffer, 0, message.Length);
            stream.Write(Encoding.UTF8.GetBytes(message2), 0, message2.Length);
            stream.Flush();


            //Read operation in text file
            byte[] outBytes = new byte[file2.Length];
            int totalNumberofBytes = stream.Read(outBytes, 0, (int)file2.Length);
            string text = Encoding.UTF8.GetString(outBytes);
            Console.WriteLine(text);
            Console.WriteLine(totalNumberofBytes);

            //File delete 
            string filePath = "../../../Example/information.txt";
            FileInfo file3 = new FileInfo(filePath);
            if (file2.Exists)
            {
                file2.Delete();
            }
            else
            {
                Console.WriteLine("File not exist here!");
            }

            //Directory operation in filesystem

            //directory create
            string path3 = "../../../Example";
            if (!Directory.Exists(path3))
            {
                Directory.CreateDirectory(path3);
                Console.WriteLine("The directory has been created!");
            }
            else
            {
                Console.WriteLine("The directory alredy exist");
            }

            //Directory delete
            string path4 = "../../../Example2";
            if (Directory.Exists(path4))
            {
                Directory.Delete(path4, true);
            }
            else
            {
                Console.WriteLine("Directory does not exist!");
            }


            //use DirectoryInfo use to create directory and file this support all in system...
            string path5 = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirectory = new DirectoryInfo(path5);
            string newPath = Path.Combine(currentDirectory.Parent.Parent.Parent.FullName, "Exam");
            Console.WriteLine(newPath);
            DirectoryInfo directoryInfo = new DirectoryInfo(newPath);

            try
            {
                if (!directoryInfo.Exists)
                {
                    directoryInfo.Create();
                    Console.WriteLine("Directory has been created!");

                    FileInfo fileInfo = new FileInfo(newPath + "/test.txt");
                    if (!fileInfo.Exists)
                    {
                        fileInfo.Create();
                        Console.WriteLine("File has been created!");
                    }
                    else
                    {
                        Console.WriteLine("The file already exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Directory already exist!");

                    FileInfo fileInfo = new FileInfo(newPath + "/test.txt");
                    if (!fileInfo.Exists)
                    {
                        fileInfo.Create();
                        Console.WriteLine("File has been created!");
                    }
                    else
                    {
                        Console.WriteLine("The file already exist!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //directory inforamtion get...
            Console.WriteLine(Directory.GetCurrentDirectory());
            DirectoryInfo myDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            string path6 = Path.Combine(myDirectory.Parent.Parent.Parent.FullName, "Temp");
            Console.WriteLine(path2);


            foreach (DirectoryInfo directory in myDirectory.Parent.GetDirectories())
            {
                foreach (FileInfo fileInfo in directory.GetFiles())
                {
                    Console.WriteLine(fileInfo.Name);
                }
            }
        }
    }
}

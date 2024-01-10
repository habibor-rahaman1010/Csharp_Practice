using System;

namespace FileSystemPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Here use static File class to create file
            string path = "../../../Examples/exam.txt";

            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    Console.WriteLine("The file is created!");
                }
                else
                {
                    Console.WriteLine("The file already exist!");
                    //File.Delete(path);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            // delete the file
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine("The file has been deleted!");
                }
                else
                {
                    Console.WriteLine($"Does not exist this {path} file in computer");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }


            //Here create a directory use static Directory class...
            string path1 = "../../../Inforamtion";
            try
            {
                if (!Directory.Exists(path1))
                {
                    Directory.CreateDirectory(path1);
                    Console.WriteLine("The directory has been created");
                    if (!File.Exists(path1 + "/info.txt"))
                    {
                        File.Create(path1 + "/info.txt");
                        Console.WriteLine("The file is created!");
                    }
                    else
                    {
                        Console.WriteLine("The file already exist!");
                    }
                }
                else
                {
                    Console.WriteLine("The directory already exist!");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            //For delete the directory in this code...
            try
            {
                if (Directory.Exists(path1))
                {
                    Directory.Delete(path1, true);
                    Console.WriteLine("Directory has been deleted!");
                }
                else
                {
                    Console.WriteLine($"Does not exist this {path1} file in computer");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            // This is code for as file writing 
            string path6 = "../../../hello.txt";
            string text = "Hello Programmer How Are You?";
            File.WriteAllText(path6, text);


            //this code for reading....
            string path7 = "../../../hello.txt";
            Console.WriteLine(File.ReadAllText(path7));
        }
    }
}

using System;
using System.IO;

namespace ConsoleApp4_OOP_C8
{
    class Program
    {
        static void Main(string[] args)
        {

            //вывод дерева


            string dirName = "C:\\";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }

                //создание папки (TESTDIR) в подкаталоге

            {
                var directory = new DirectoryInfo(@".");
                Console.WriteLine(directory.FullName);
               
                if (directory.Exists)
                {
                    
                    directory.CreateSubdirectory("SUBDIR");

                   
                    directory.CreateSubdirectory(@"MyDir\SubMyDir");

                    Console.WriteLine("Директории созданы.");
                }
                else
                {
                    Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
                }

                
                Console.ReadKey();
            }
           
            {
                string sourceFile = @"C:\Users\Public\public\test.txt";
                string destinationFile = @"C:\Users\Public\private\test.txt";

               
                System.IO.File.Move(sourceFile, destinationFile);

                
                System.IO.Directory.Move(@"C:\Users\Public\public\test\", @"C:\Users\Public\private");
            }
        }

        //копируем файлы

        static void Main()
        {
            
            var file = new FileInfo(@"C:\Windows\notepad.exe");

            try
            {
                file.CopyTo(@"D:\notepad.exe");
                Console.WriteLine("Файл успешно скопирован!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

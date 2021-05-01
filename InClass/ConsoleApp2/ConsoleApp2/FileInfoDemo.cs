using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class FileInfoDemo
    {

        public static void CreateDir() {

                var dirpath = Path.Combine(@"C:\husohome\c_sharp\ConsoleApp2\test\");
                if (!Directory.Exists(dirpath))
                {
                    Directory.CreateDirectory(dirpath);
                }
                else
                {
                    Console.WriteLine("directory already exists");
                }
                Console.WriteLine("dir created");
            }

        public static void DelDir() {

                var dirpath = Path.Combine(@"C:\husohome\c_sharp\ConsoleApp2\test\");
                var deleteSub = false;
                Directory.Delete(dirpath , deleteSub);
                Console.WriteLine($"dir deleted with param delesub=={deleteSub}");
        }
        

        public static void main(string[] args) {


            CreateDir();
            DelDir();

            //var filePath = Path.Combine(@"C:\husohome\c_sharp\ConsoleApp2\", "test.txt");
            //FileInfo fileInfo = new FileInfo(filePath);

            //using (StreamReader sr = fileInfo.OpenText()) 
            //{
            //    var str = string.Empty;
            //    while ((str = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(str);
            //    }

            //}
            //Console.ReadLine();

            //var toWrite = new string[] { "hehehee", "muasdsadsaca" };
            ////to overwrite
            //using (StreamWriter sw = fileInfo.CreateText())
            //{
            //    foreach (var line in toWrite)
            //    {
            //        sw.WriteLine(line);
            //    }
            //}
            ////to simply append
            //using (StreamWriter sw = fileInfo.AppendText())
            //{
            //    foreach (var line in toWrite)
            //    {
            //        sw.WriteLine(line);
            //    }
            //}

            ////to copy
            //var targetPath = "C:\\husohome\\c_sharp\\ConsoleApp2\\testCopy.txt";
            //var targetFileInfo = new FileInfo(targetPath);
            //if(!fileInfo.Exists)
            //{
            //    return;
            //}
            //else
            //{
            //    if (targetFileInfo.Exists) {
            //        targetFileInfo.Delete();
            //    }
            //    fileInfo.CopyTo(targetPath);
            //}

        }

    }
}

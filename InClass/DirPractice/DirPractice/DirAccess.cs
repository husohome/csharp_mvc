using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirPractice
{
    class DirAccess
    {

        public static void CreateDir()
        {

            var dirpath = Path.Combine(@"C:\husohome\c_sharp\DirPractice\test\");

            try
            {

                Directory.CreateDirectory(dirpath);

            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);

            }
            catch (Exception)
            {

                Console.WriteLine("Something went wrong.");
            }

            Directory.CreateDirectory(dirpath);

        }

        public static void DelDir()
        {

            var dirpath = Path.Combine(@"C:\husohome\c_sharp\DirPractice\test\");

            try
            {

                Directory.Delete(dirpath);

            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);

            }
            catch (Exception e)
            {

                Console.WriteLine("Something went wrong.");
            }

            Directory.CreateDirectory(dirpath);

        }

        public static void MoveFiles() {

            var srcDir = Path.Combine(@"C:\husohome\c_sharp\DirPractice\test\");
            var targetDir = Path.Combine(@"C:\husohome\c_sharp\DirPractice\test\testTarget\");

            try
            {
                var files = Directory.EnumerateFiles(srcDir, "*.txt"); // find all .txt files
                foreach (var file in files)
                {
                    // get filename
                    var fileName = file.Substring(srcDir.Length + 1); // start at 
                    Directory.Move(file, Path.Combine(targetDir, 
                                                        fileName));

                }

            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception) {
                Console.WriteLine("something went wrong");
            }

        
        }


    }

}

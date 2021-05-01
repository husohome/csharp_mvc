using ConsoleApp2.Models;
using ConsoleApp2.Views;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "C:\\husohome\\c_sharp\\ConsoleApp2\\test.txt";
            var targetPath = "C:\\husohome\\c_sharp\\ConsoleApp2\\testCopy.txt";
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                Console.WriteLine(line + "\t");
            }
            Console.ReadLine();

            string[] str = new string[] { "hello", "hello" };
            File.Copy(filePath, targetPath, true);

        }
    }
}

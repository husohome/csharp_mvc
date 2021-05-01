using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    class AsyncPrac
    {
        public static void Run0() {
            Console.WriteLine($"Run0 started => {DateTime.Now.ToString()}");
            SlowA();
            SlowB();
            Console.WriteLine($"Run0 (regular) done! => {DateTime.Now.ToString()}");

        }

        public static void Run()
        {
            Console.WriteLine($"Run started => {DateTime.Now.ToString()}");
            Task.Run(() => SlowA());
            Task.Run(() => SlowB());
            Console.WriteLine($"Run (with Task.Run) done! => {DateTime.Now.ToString()}");

        }

        public static void Run1() {
            Console.WriteLine($"Run1 started => {DateTime.Now.ToString()}");
            var task = Task.Run(() => SlowC());
            Console.WriteLine($"task.Result = {task.Result}");
            Console.WriteLine($"Run1 (with Task.Run() and Task.Result done! => {DateTime.Now.ToString()}");
        
        }

        public static void Run2() {
            Console.WriteLine($"Run2 started => {DateTime.Now.ToString()}");
            var task1 = Task.Run(() => SlowA());
            task1.Wait(); // to ensure task1 gets done before task 2
            var task2 = Task.Run(() => SlowB());
            Console.WriteLine($"Run2 (with task.Wait()) done! => {DateTime.Now.ToString()}");
        }

        public static void Run3()
        {
            Console.WriteLine($"Run3 started => {DateTime.Now.ToString()}");
            var task1 = Task.Run(() => SlowA());
            var task2 = Task.Run(() => SlowB());
            var tasks = new Task[] { task1, task2 };
            Task.WaitAll(tasks);
            Console.WriteLine($"Run3 (with Task.WaitAll()) done! => {DateTime.Now.ToString()}");

        }
        public static void Run4(){
            Console.WriteLine($"Run4 started => {DateTime.Now.ToString()}");
            var task1 = Task.Run(() => SlowA());
            var task2 = Task.Run(() => SlowB());
            var tasks = new Task[] { task1, task2 };
            Task.WhenAll(tasks);
            Console.WriteLine($"Run4 (with Task.WhenAll()) done! => {DateTime.Now.ToString()}");
        }

        public static async Task Run5() {
            Console.WriteLine($"Run5 started => {DateTime.Now.ToString()}");
            var task1 = Task.Run(() => SlowA());
            var task2 = Task.Run(() => SlowB());
            var tasks = new Task[] { task1, task2 };
            await Task.WhenAll(tasks);
            Console.WriteLine($"Run5 (with async and await) done! => {DateTime.Now.ToString()}");

        }

        public static async Task MyDownloadAsync() {
            Console.WriteLine($"MyDownloadAsync started => {DateTime.Now.ToString()}");
            var wc = new WebClient();
            string url = "https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/variance-in-delegates";
            Task<string> t = wc.DownloadStringTaskAsync(url);
            await t;
            Console.WriteLine($"MyDownloadAsync (with async and await, DownloadStringTaskAsync()) done! => {DateTime.Now.ToString()}");
        }

        public static async Task<string> MyDownloadWithReturnsAsync() {
            Console.WriteLine($"MyDownloadWithReturnsAsync started => {DateTime.Now.ToString()}");
            var wc = new WebClient();
            string url = "https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/variance-in-delegates";
            Task<string> t = wc.DownloadStringTaskAsync(url);
            var result = await t;
            Console.WriteLine($"MyDownloadWithReturnsAsync (with async and await, and Task<string> DownloadStringTaskAsync()) done! => {DateTime.Now.ToString()}");
            return result;
        }

        public static void SlowA() {
            Thread.Sleep(5000);
            Console.WriteLine($"SlowA done! => {DateTime.Now.ToString()}" );

        }

        public static void SlowB()
        {
            Thread.Sleep(3000);
            Console.WriteLine($"SlowB done! => {DateTime.Now.ToString()}");

        }

        public static int SlowC() {
            Thread.Sleep(3000);
            return 100;
        }

    }
}

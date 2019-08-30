using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        private static async Task Task1Async()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Task 1");
            });
        }
        
        private static async Task Task2Async()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Task 2");
            });
        }
        
        private static async Task Task3Async()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Task 3");
            });
        }
        
        private static async Task Task4Async()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Task 4");
            });
        }
        
        private static async Task Task5Async()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Task 5");
            });
        }
        
        static async Task Main(string[] args)
        {
            var timer = new Stopwatch();
            timer.Start();
            await Task1Async();
            await Task2Async();
            await Task3Async();
            await Task4Async();
            await Task5Async();
            timer.Stop();
            Console.WriteLine($"Time: {timer.ElapsedMilliseconds}ms");
            
            timer.Restart();
            await Task.WhenAll(new List<Task> {Task1Async(), Task2Async(), Task3Async(), Task4Async(), Task5Async()});
            timer.Stop();
            Console.WriteLine($"Time: {timer.ElapsedMilliseconds}ms");
            Console.ReadLine();
        }
    }
}
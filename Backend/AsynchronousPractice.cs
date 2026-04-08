using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    public class AsynchronousPractice
    {
        // Asynchronous method 
        public async Task GetDataAsync()
        {
            await Task.Run(() => GetData());
        }
        // Synchronous method
        public string GetData()
        {
            Console.WriteLine("Sync");
            Thread.Sleep(2000); // simulate API call
            Console.WriteLine("Sync");
            return "Data";
        }

        public async Task TaskPractice()
        {
            var tasks = new List<Task>();

            for (int i = 0; i < 5; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    Console.WriteLine($"Task {i} running");
                }));
            }

            await Task.WhenAll(tasks);
        }

        public async Task MultithreadPractice()
        {
            Thread t1 = new Thread(() => PrintNumbers());
            Thread t2 = new Thread(() => PrintLetters());

            t1.Start();
            t2.Start();
        }

        public void PrintNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Number: {i}");
            }
        }

        public void PrintLetters()
        {
            for (char c = 'A'; c < 'F'; c++)
            {
                Console.WriteLine($"Letter: {c}");
            }
        }

        // Full code practice of above methods

        public async Task FullPractice()
        {
            Console.WriteLine("===== Async / Await Demo =====");
            await AsyncMethod();

            Console.WriteLine("\n===== Task.Run (CPU Work) =====");
            await RunCpuWork();

            Console.WriteLine("\n===== Multithreading =====");
            Multiplethread();

            Console.WriteLine("\n===== Parallel.For =====");
            ParallelFor();

            Console.WriteLine("\n===== Thread Safety Issue =====");
            ParallelForSafe();

            Console.ReadLine();
        }

        static async Task AsyncMethod()
        {
            Console.WriteLine("Before await");
            await Task.Delay(5000);  // simulate I/O
            Console.WriteLine("After await");
        }

        static async Task RunCpuWork()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Heavy Work Started....");
                Thread.Sleep(5000);  // simulate CPU Work
                Console.WriteLine("Heavy Work Finished....");
            });
        }

        static void Multiplethread()
        {
            Thread t1 = new Thread(() =>
            {
                for(int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Multiple thread Numbers: {i}");
                    Thread.Sleep(500);
                }
            });
            Thread t2 = new Thread(() => {
                for(char a = 'a'; a <= 'f'; a ++)
                {
                    Console.WriteLine($"Multiple thread Letters: {a}");
                    Thread.Sleep(500);
                }
            });

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            // Checks if thread is still running.
            bool status1 = t1.IsAlive;
            bool status2 = t2.IsAlive;

            Console.WriteLine($"Status1 = {status1}");
            Console.WriteLine($"Status1 = {status2}");
        }

        static void ParallelFor()
        {
            Parallel.For(0, 10, p =>
            {
                Console.WriteLine($"Parellel Index: {p} | Thread: {Thread.CurrentThread.ManagedThreadId}");
            });
        }

        static void ParallelForSafe()
        {
            int count = 0;

            Parallel.For(0, 1000, i =>
            {
                Interlocked.Increment(ref count);
            });
            Console.WriteLine($"Final Count for ParallelForSafe: {count}");
        }
    }
}

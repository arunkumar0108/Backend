using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    public class AsynchronousPractice
    {
        public static void Staticmethod(string message)
        {
            Console.WriteLine($"Static method called message: {message}");
        }

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

        static int stock = 5;
        static readonly object lockObj = new object();

        public async Task Main1()
        {
            var t1 = Task.Run(() => PlaceOrder("User1"));
            var t2 = Task.Run(() => PlaceOrder("User2"));
            var t3 = Task.Run(() => PlaceOrder("User3"));

            await Task.WhenAll(t1, t2, t3);

            Console.WriteLine($"Final Stock: {stock}");
        }

        static void PlaceOrder(string user)
        {
            lock (lockObj)
            {
                if (stock > 0)
                {
                    Console.WriteLine($"{user} placing order...");
                    stock--;
                }
                else
                {
                    Console.WriteLine($"{user} failed - Out of stock");
                }
            }
        }


        static object obj1 = new object();
        static object obj2 = new object();

        static async Task Main2()
        {
            Console.WriteLine("===== DEADLOCK EXAMPLE (WILL FREEZE) =====");

            // Uncomment this to see deadlock

            Task t1 = Task.Run(() => DeadlockMethod1());
            Task t2 = Task.Run(() => DeadlockMethod2());

            await Task.WhenAll(t1, t2);


            Console.WriteLine("===== DEADLOCK FIX (SAFE) =====");

            Task t3 = Task.Run(() => SafeMethod1());
            Task t4 = Task.Run(() => SafeMethod2());

            await Task.WhenAll(t3, t4);

            Console.WriteLine("Completed without deadlock 👍");
        }

        // ❌ Deadlock Method 1
        static void DeadlockMethod1()
        {
            lock (obj1)
            {
                Console.WriteLine("Thread 1 locked obj1");
                Thread.Sleep(100);

                lock (obj2)
                {
                    Console.WriteLine("Thread 1 locked obj2");
                }
            }
        }

        // ❌ Deadlock Method 2
        static void DeadlockMethod2()
        {
            lock (obj2)
            {
                Console.WriteLine("Thread 2 locked obj2");
                Thread.Sleep(100);

                lock (obj1)
                {
                    Console.WriteLine("Thread 2 locked obj1");
                }
            }
        }

        // ✅ Fixed Method 1 (same order)
        static void SafeMethod1()
        {
            lock (obj1)
            {
                Console.WriteLine("Safe Thread 1 locked obj1");
                Thread.Sleep(100);

                lock (obj2)
                {
                    Console.WriteLine("Safe Thread 1 locked obj2");
                }
            }
        }

        // ✅ Fixed Method 2 (same order)
        static void SafeMethod2()
        {
            lock (obj1) // SAME ORDER 👈
            {
                Console.WriteLine("Safe Thread 2 locked obj1");
                Thread.Sleep(100);

                lock (obj2)
                {
                    Console.WriteLine("Safe Thread 2 locked obj2");
                }
            }
        }
    }
}

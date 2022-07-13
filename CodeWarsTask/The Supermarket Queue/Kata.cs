using System;
using System.Threading;

namespace CodeWarsTask.The_Supermarket_Queue
{
    public class Kata
    {
        // https://www.codewars.com/kata/57b06f90e298a7b53d000a86/train/csharp
        // https://docs.microsoft.com/ru-ru/dotnet/api/system.threading.threadpool.queueuserworkitem?view=net-6.0#system-threading-threadpool-queueuserworkitem(system-threading-waitcallback-system-object)
        // https://docs.microsoft.com/ru-ru/dotnet/api/system.threading.manualresetevent?view=net-6.0
        //private static void Main()
        //{
        //    QueueTime(new int[] { 10, 2, 3, 3 }, 2);
        //}

        public static long QueueTime(int[] customers, int n)
        {
            Console.WriteLine("Main start");

            //for (int i = 0; i < length; i++)
            //{

            //}

            ThreadPool.QueueUserWorkItem(TestGayMethod, n);

            Console.WriteLine("Main finish");

            Thread.Sleep(2000);

            return 0;
        }

        private static void TestGayMethod(object arg)
        {
            Console.WriteLine((int)arg);
            Console.WriteLine("Hello from parallel thread");
        }
    }
}

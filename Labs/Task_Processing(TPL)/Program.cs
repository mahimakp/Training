using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Processing_TPL_
{
    class Program
    {
        static void Main(string[] args)
        {

            Task t1 = new Task(Func1);
            Task t2 = new Task(Func2);

            t1.Start();
            t2.Start();

            Console.WriteLine("Hello World!");
            Console.Read();
        }

        static void Func1()
        {

            Thread.Sleep(10000);
            Console.WriteLine("Inside Func1");
        }

        static void Func2()
        {
            
            Console.WriteLine("Inside Func2");
        }
    }
}

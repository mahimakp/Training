using System;
using System.Threading;


namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread t1 = new Thread(
                        new ThreadStart(Func1)
                        );

            Thread t2 = new Thread(
                        new ThreadStart(Func2)
                        );

            t1.Start();
            t2.Start();

            Console.WriteLine("Hello World");
            Console.Read();
        
        }

        static void Func1()
        {

            Thread.Sleep(1000);
            Console.WriteLine("Inside Func1");
        }

        static void Func2()
        {
            
            Console.WriteLine("Inside Func2");
        }
    }
}

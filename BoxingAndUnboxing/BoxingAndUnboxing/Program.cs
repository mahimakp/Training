using System;
using System.Diagnostics;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Stopwatch s = new Stopwatch();
            
            
            s.Start();
            Performance();
            s.Stop();
            
            Console.WriteLine(s.ElapsedMilliseconds);
            
            s.Restart();
            s.Start();
            Performance();
            s.Stop();

            Console.WriteLine(s.ElapsedMilliseconds);

            s.Restart();
            s.Start();
            Performance();
            s.Stop();

            Console.WriteLine(s.ElapsedMilliseconds);

            Console.Read();
            Console.WriteLine("This is main");
        }

        static void Performance()


        {
            for (int i = 0; i < 100000000; i++)
            {

                int a = 10;
                object b = a;
            }
        }

    }

}

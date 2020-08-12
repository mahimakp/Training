using System;

namespace Delegates_1
{
    class Program
    {

        delegate void PointtoFunc1();
        static PointtoFunc1 p;
        static void Main(string[] args)
        {
            p += Func1;
            p += Func2;
            p.Invoke();

            Console.WriteLine("Hello World!");
        }

        static void Func1()
        {
            Console.WriteLine("Inside Func1");
        }

        static void Func2()
        {
            Console.WriteLine("Inside Func2");
        }

    }
}

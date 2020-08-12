using System;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileParser p = new FileParser();
           
            p.Ppointer += Display;
            p.Ppointer += Display1;

            //p.Ppointer = null;

            Task t = new Task(p.Parse);
            t.Start();
            
            Console.WriteLine("This is main");
            Console.ReadLine();
        }

        static void Display(int i)
        {
            Console.WriteLine("First" + i);
          
        }
       
        static void Display1(int i)
        {

            Console.WriteLine("Second" + i);
        }

    }

    public class FileParser
    {

        public delegate void parsepoint(int i);
        public event parsepoint Ppointer;

        public void Parse()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Ppointer.Invoke(i);
            }

        }
    }
}

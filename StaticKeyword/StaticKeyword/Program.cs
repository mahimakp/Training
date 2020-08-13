using StaticKeywordClassLibrary;
using System;

namespace StaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //   GlobalValue value = new GlobalValue();
            //   value.increment();

            StaticExample instanceVaiable = new StaticExample();
            //instanceVaiable.count;

            int counter = GlobalValue.increment();
            

        }
    }
}

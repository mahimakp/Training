using System;

namespace StaticKeywordClassLibrary
{
    public class StaticExample
    {
        public int count = 10;

    }
    public static class GlobalValue
    {

        static int count = 1;
           
        public static int increment()
        {
            return count++;
        }
    }
}

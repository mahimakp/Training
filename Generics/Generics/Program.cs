using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericExample<int> intAmount = new GenericExample<int>();

            int paidAmount = 10000;
            int AmountToBePaid = 10000;
            bool resultInt = intAmount.Check(paidAmount, AmountToBePaid);

            GenericExample<string> stringCheck = new GenericExample<string>();
            string name1 = "Mahima";
            string name2 = "Mahima";
            bool resultString = stringCheck.Check(name1, name2);



        }
    }

    public class GenericExample<T>
    {
        public bool Check(T value1, T value2)
        {
            if (value1.Equals(value2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

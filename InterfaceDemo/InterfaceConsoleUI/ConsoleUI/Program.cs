using System;
using PaymentInterface;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            iPaymentMethods pay = Factory.Create(0);
            
            pay.AmountToBePaid = 5000;
            pay.PaidAmount = 5000;
            pay.Payment();
            




            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentInterface
{
    public static class Factory
    {
        public static iPaymentMethods Create(int i)
        {

            if (i == 0)
            {
                return new PayByCash();
            }
            else
            {
                return new PayOnline();
            }
            
                 
        }
    }
}

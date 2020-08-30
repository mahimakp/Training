using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
    public interface iPaymentMethods
    {
        string Payment();
        int AmountToBePaid { get; set; }
        int PaidAmount { get; set; }
    }

    public abstract class AbstractClass :iPaymentMethods
    {
        public abstract int AmountToBePaid { get; set; }
        public abstract string Payment();
        public abstract int PaidAmount { get; set; }

    }
    public class PayByCash : AbstractClass
    {
        override
        public int AmountToBePaid{ get; set; }

        override
        public int PaidAmount{ get; set; }

        override
        public string Payment()
        {
            if (AmountToBePaid == PaidAmount)
            {
                return "Amount Paid";
            }
            else
            {
                return "Pending payment";
            }
        }
    }

    public class PayOnline : AbstractClass
    {
        override
        public int AmountToBePaid{ get; set; }

        private int BankBalance = 50000;

        override
        public int PaidAmount{ get; set; }
        override
        public string Payment()
        {
            if (BankBalance >= AmountToBePaid && AmountToBePaid == PaidAmount)
            {
                return "Transaction successful";

            }
            else
            {
                return "Transaction failed";

            }
        }

    }
}

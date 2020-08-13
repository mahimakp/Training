using System;
using StaffNS;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientNS

{
    public class Patient
    {
        internal string Name { get; set; }
        internal string Gender { get; set; }
        internal string Address { get; set; }
        internal long PhoneNumber { get; set; }
        internal string EmailId { get; set; }
        internal Doctor doctor { get; set; }
        internal List<HealthIssues> healthIssues { get; set; }

        public void Visit()
        {
            Console.WriteLine("Visting the Doctor...");

        }
        public void PayBills()
        {
            Console.WriteLine("Paying the treatment amount..");

        }

    }

    public class HealthIssues
    {


        internal List<Medication> treatment { get; set; }
        internal List<string> Symptoms { get; set; }
        internal string Duration { get; set; }



    }
    public class Medication
    {
        internal HealthIssues healthIssues { get; set; }
        internal string PrescriptionsName { get; set; }
        internal List<string> Frequency { get; set; }
    }

}

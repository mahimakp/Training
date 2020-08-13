using PatientNS;
using StaffNS;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("If patient visit receiption counter.....");
            ReceptionCounter reception = new ReceptionCounter();

            Console.WriteLine("If staff member visit Admin team");
            Admin admin = new Admin();


        }
    }

    class ReceptionCounter
    {
        public Patient patient { get; set; }
        public HealthIssues health { get; set; }


        public void UpdateInfoOfPatient()
        {
            Console.WriteLine("Update patient info in database");
        }

    }

    class Admin
    {

        public Doctor doctor { get; set; }
        public Nurse nurse { get; set; }
        public Wardboy wardboy { get; set; }
        public Accountant accountant { get; set; }
        public void UpdateInfoOfStaff()
        {
            Console.WriteLine("Update Staff info in database");
        }
    }
}

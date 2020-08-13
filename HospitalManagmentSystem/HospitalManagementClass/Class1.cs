using PatientNS;
using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace StaffNS

{
    public class Staff
    {
        protected string ID { get; set; }
        protected string Name { get; set; }
        protected string Gender { get; set; }
        protected string Address { get; set; }
        protected long ContactNumber { get; set; }
        protected string EmailID { get; set; }
        protected string ShiftTime { get; set; }

    }

    public class Doctor : Staff
    {
        private Patient patient { get; set; }
        private List<Nurse> nurse { get; set; }
        private Wardboy wardboy { get; set; }
        private string Specialist { get; set; }
        private string Experience { get; set; }

        private void prescribesMedicines()
        {
            Console.WriteLine("Mentioned medication should be needed......");

        }


    }

    public class Nurse : Staff
    {
        private string Designation { get; set; }
        private string Qualification { get; set; }
        private Wardboy wardboy { get; set; }
        private void WorkWithDoctor()
        {
            Console.WriteLine("Completing the tasks given by doctor...");
        }
    }

    public class Wardboy : Staff
    {
        private void ArrangeWards()
        {
            Console.WriteLine("Arranging Wards according to the requirement...");
        }
    }

    public class Accountant : Staff
    {
        private void Salary()
        {
            Console.WriteLine("Calculating Salary for Staff...");
        }
    }
}

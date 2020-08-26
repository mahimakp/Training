using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
    public interface Work
    {
        string AttendsPatient();
       
    }
    public class Staff
    {
        public string name { get; set; }
        public int dateOfJoining { get; set; }
        public string department { get; set; }
    }

    public class Doctor : Staff
    {
        public string specialization { get; set; }

        public List<Patient> patients = new List<Patient>();
        public string TreatPatient()
        {
            return "Treat Patient";
        }

    }

    public class Wardboy : Staff, Work
    {
        public string AttendsPatient()
        {
            return "Allot wards to Patient";
        }
    }

    public class Nurse : Staff, Work
    { 
        public string AttendsPatient()
        {
            return "Provides medication";
        }
    }

}

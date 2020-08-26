using System;
using System.Collections.Generic;

namespace HospitalModel
{
    public class Patient
    {
        public string name { get; set; }
        public string address { get; set; }
        public int phoneNumber { get; set; }

        public List<Allergy> allergies = new List<Allergy>();

        public List<Problem> problems = new List<Problem>();

        public Doctor doctor { get; set; }

        public List<Wardboy> wardboys = new List<Wardboy>();

        public List<Nurse> nurses = new List<Nurse>();


    }

    public class Allergy
    {
        public string allergyName { get; set; }
        public string allergyDescription { get; set; }
        public int allergyDuration { get; set; }
        public Patient patient { get; set; }

    }

    public class Problem
    {
        public string problemName { get; set; }
        public string problemDescription { get; set; }
        public int problemDuration { get; set; }
        
      
    }

    public class Visit
    {
        public int visits = 0;
    }

    public class Treatment
    {
        public string medicineName { get; set; }
        public int doses { get; set; }
    }
}

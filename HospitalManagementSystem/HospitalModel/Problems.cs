using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
    public class Visit
    {
        public int visitCount = 0;
        public string timestamp = "";
        public List<Problem> problems = new List<Problem>();
        
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

        public List<Treatment> treatments = new List<Treatment>();


    }

}

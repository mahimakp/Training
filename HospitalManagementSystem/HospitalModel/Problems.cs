using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
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

        List<Treatment> treatments = new List<Treatment>();


    }

}

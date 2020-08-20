using System;
using System.Collections.Generic;

namespace PatientLibrary
{
    public class Patient
    {
        public string name { get; set; }
        public string address { get; set; }
        public List<PatientProblem> problems { get; set; }
    }
    public class PatientProblem
    {
        public string problem { get; set; }
    }
}

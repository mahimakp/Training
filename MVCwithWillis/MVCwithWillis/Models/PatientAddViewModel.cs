using PatientLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCwithWillis.Models
{
    public class PatientAddViewModel
    {
         
        public List<Patient> allPatients { get; set; }
        public Patient currentPatient { get; set; }
        public List<PatientProblem> patientProblems { get; set; }
        public PatientProblem currentProblem { get; set; }
    }
}

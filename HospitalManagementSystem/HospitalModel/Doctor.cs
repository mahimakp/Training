using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
    public class Doctor : Staff, iStaff
    {
        Salary salary = new Salary();

        public double CalculateDoctorSalary()
        {
            return salary.GetSalary(patients.Count);
        }

        private string specialization { get; set; }

        private List<Patient> patients = new List<Patient>();
        private bool availability { get; set; }


        public string AttendsPatient()
        {
            return "Prescribe medication/treatment to patient";
        }
    }

}

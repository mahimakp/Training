using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HospitalModel
{
    public class Doctor : Staff, iStaff
    {
        Salary salary = new Salary();

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetDoj(string doj)
        {
            this.dateOfJoining = doj;
        }

        public void SetDepartment(string deptName)
        {
            this.department = deptName;
        }
        public string GetDoctorInfo()
        {
            return ("Name : " + this.name + "Date of Joining : " + this.dateOfJoining + "Department :" + this.department);
        }      
        public bool GetAvailiablity()
        {
            return this.availability;
        }

        public double CalculateDoctorSalary()
        {
            return salary.GetSalary(patients.Count);
        }
        public void SetAvaliablity(bool status)
        {
            this.availability = status;
        }

        public void SetSpecialization(string specialization)
        {
            this.specialization = specialization;
        }

        public void SetPatients(List<Patient> p)
        {
            this.patients = p;
        }
        internal string specialization { get; set; }

        internal List<Patient> patients = new List<Patient>();
        internal bool availability;

        public string AttendsPatient()
        {
            return "Prescribe medication/treatment to patient";
        }
    }

}

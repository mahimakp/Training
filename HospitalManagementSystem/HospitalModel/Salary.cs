using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
    class Salary
    {
        private double salary;

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }

        public double GetSalary(int noOfPatient)
        {
            return salary * noOfPatient;
        }


    }
}

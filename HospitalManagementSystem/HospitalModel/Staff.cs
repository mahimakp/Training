using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HospitalModel
{
    interface iStaff
    {
        string AttendsPatient();
    }

    public class Staff
    {

        protected string name { get; set; }
        protected int dateOfJoining { get; set; }
        protected string department { get; set; }

        Salary salary = new Salary();

        public double StaffSalary()
        {
            return salary.GetSalary();
        }

    }
}

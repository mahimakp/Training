using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
    class Accountant : Staff
    {
        public double amount { get; set; }

        Salary salary;
        
        public void SetStaffSalary()
        {
            salary.SetSalary(amount);
        }
    }

}

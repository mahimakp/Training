using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
    class Accountant : Staff
    {
        private double amount = 10000;

        Salary salary;
        
        public void SetStaffSalary()
        {
            salary.SetSalary(amount);
        }
    }

}

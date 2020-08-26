using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
    public class Nurse : Staff, iStaff
    {

        public string AttendsPatient()
        {
            return "Provides needed service to patient";
        }
    }
}

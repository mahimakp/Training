using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
    public class Wardboy : Staff, iStaff
    {

        public string AttendsPatient()
        {
            return "Allot wards to Patient";
        }

    }


}

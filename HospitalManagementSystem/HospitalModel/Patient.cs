﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalModel
{
    public class Patient 
    {
        [Required]
        public string name { get; set; }
        public string address { get; set; }

        [Required]
        public long phoneNumber { get; set; }

        public List<Allergy> allergies = new List<Allergy>();

        //public List<Problem> problems = new List<Problem>();

        public Doctor doctor { get; set; }

        public List<Wardboy> wardboys = new List<Wardboy>();

        public List<Nurse> nurses = new List<Nurse>();

        public List<Visit> visitList = new List<Visit>();
        public bool visits { get; set; }
        public iPaymentMethods PayFees(int option)
        {

            if (option == 0)
            {
                return new PayByCash();
            }
            else
            {
                return new PayOnline();
            }


        }
    }

    

   
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalModel
{
    public class Treatment
    {
        internal string medicineName { get; set; }
        internal int doses { get; set; }

        public void SetMedicineName (string medName)
        {
            this.medicineName = medName;

        }
        public void SetDoses(int dose)
        {
            this.doses = dose;

        }

        public string GetTreatment()
        {
            return ("Medicine name : " + this.medicineName + " Doses : " + this.doses);
        } 
    }
}

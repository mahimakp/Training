using System;
using System.Collections.Generic;

namespace PatientLibrary
{
    public interface IPatient
    {
       
        string name { get; set; }
        string address { get; set; }
         List<PatientProblem> problems { get; set; }
        bool Validate();
         string guid { get; set; }
    }
    public class Patient : IPatient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public List<PatientProblem> problems { get; set; }
        public string guid { get; set; }
        public Patient()
        {
            this.problems = new List<PatientProblem>();
            this.guid = Guid.NewGuid().ToString();
        }
        public virtual bool Validate()
        {
            if (name.Length == 0)
            {
                throw new Exception("name is needed");
            }
            return true;
        }

    }
    public class PatientWithAddressCheck : Patient , IPatient
    {
        public override bool Validate()
        {
            if (name.Length == 0)
            {
                throw new Exception("name is needed");
            }
            if (address.Length == 0)
            {
                throw new Exception("address is needed");
            }
            return true;
        }
    }
    public class PatientProblem
    {
        public int id { get; set; }
        public string problem { get; set; }
        public List<Treatment> treatments { get; set; }
        public PatientProblem()
        {
            this.treatments = new List<Treatment>();
        }
       
    }

    public class  Treatment 
    {
        public int id { get; set; }
        public string medicineName { get; set; }
        public int numberOfTimesInDay { get; set; }
    }

}

using HospitalModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace HospitalManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Doctor info
            List<Patient> patientList = new List<Patient>();

            Doctor d1 = new Doctor();

            d1.SetName("Dr. Drake Ramoray");
            d1.SetDoj("13 May 1997");
            d1.SetDepartment("Doctor");
            d1.SetAvaliablity(true);
            d1.SetSpecialization("Neurosurgeon");
            d1.SetPatients(patientList);

            if (d1.GetAvailiablity() == true)
            {
                Console.WriteLine(d1.GetDoctorInfo());
                
            }
            else
            {
                throw new Exception("Not Available");
            }


            Treatment treatment1 = new Treatment();
            Treatment treatment2 = new Treatment();

            //First patient
            Patient patient1 = new Patient();

            patient1.visits = true;

            if (patient1.visits == true)
            {

                patient1.name = "Mahima";
                patient1.address = "Nagpur";
                patient1.phoneNumber = 9673630000;
                patient1.doctor = d1;

                iPaymentMethods payfees = patient1.PayFees(0);

                payfees.AmountToBePaid = 1000;
                payfees.PaidAmount = 1000;
                Console.WriteLine(payfees.Payment());

                //Record visit
                Visit visit1 = new Visit();

                visit1.visitCount = visit1.visitCount + 1;
                visit1.timestamp = DateTime.Today.ToString();

                //Multiple problems for visit1
                Problem problem1 = new Problem();

                problem1.problemName = "Fever";
                problem1.problemDescription = "High Temperature";
                problem1.problemDuration = 3;

                Problem problem2 = new Problem();

                problem2.problemName = "Cold";
                problem2.problemDescription = "The common cold is a viral infection of your nose and throat (upper respiratory tract).";
                problem2.problemDuration = 7;

                //Treatment for problem1
                
                treatment1.SetMedicineName("Crocin");
                treatment1.SetDoses(3);

                treatment2.SetMedicineName("Vicks");
                treatment2.SetDoses(2);

                //Add problems to visitList
                visit1.problems.Add(problem1);
                visit1.problems.Add(problem2);

                //Add treatment to problem
                problem1.treatments.Add(treatment1);
                problem2.treatments.Add(treatment2);

                //Adding visit info to patient
                patient1.visitList.Add(visit1);

            }
            else
            {
                throw new Exception("Patient not visiting for checkup");

            }

          
            ////Add patient's problems to problem list
            //patient1.problems.Add(problem1);
            //patient1.problems.Add(problem2);

            //Treatment for problem1
            //Treatment treatment1 = new Treatment();

            //treatment1.SetMedicineName("Crocin");
            //treatment1.SetDoses(3);

            //add to treatements list in problem class
            //problem1.treatments.Add(treatment1);

            patientList.Add(patient1);

            Console.WriteLine(patient1.name);
            Console.WriteLine(patient1.phoneNumber);
            Console.WriteLine(patient1.address);
            Console.WriteLine(patient1.doctor);

            //foreach (var problemItem in patient1.problems)
            //{
            //    Console.WriteLine(problemItem.problemName + " " + problemItem
            //        .problemDescription + " " + problemItem.problemDuration);

            //    foreach (var treatmentItem in problem1.treatments)
            //    {
            //        Console.WriteLine(treatmentItem.GetTreatment());
            //    }

            //}

            foreach (var visitItem in patient1.visitList)
            { 
                Console.WriteLine(" Visit no. : " + visitItem.visitCount + "\nVisiting time : " + visitItem.timestamp);

                foreach (var problemItem in visitItem.problems)
                {
                    Console.WriteLine(problemItem.problemName + " " + problemItem
                    .problemDescription + " " + problemItem.problemDuration);

                    foreach (var treatmentItem in problemItem.treatments)
                    {
                        Console.WriteLine(treatmentItem.GetTreatment());
                    }
                }
            }



            //Patients patientsList = new Patients(patient1); 

            //foreach (Patient p in patientsList)
            //    Console.WriteLine(p.firstName + " " + p.lastName);
        }
    }
}

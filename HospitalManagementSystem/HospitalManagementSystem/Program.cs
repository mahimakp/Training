using HospitalModel;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HospitalManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            

            //First patient
            Patient patient1= new Patient();

            patient1.name = "Mahima";
            patient1.address = "Nagpur";
            patient1.phoneNumber = 9673630000;


            //Multiple problems for patient1
            Problem problem1 = new Problem();

            problem1.problemName = "Fever";
            problem1.problemDescription = "High Temperature";
            problem1.problemDuration = 3;

            Problem problem2 = new Problem();

            problem2.problemName = "Cold";
            problem2.problemDescription = "The common cold is a viral infection of your nose and throat (upper respiratory tract).";
            problem2.problemDuration = 7;


            //Add patient's problems to problem list
            patient1.problems.Add(problem1);
            patient1.problems.Add(problem2);

            Console.WriteLine(patient1.name);
            Console.WriteLine(patient1.phoneNumber);
            Console.WriteLine(patient1.address);

            foreach (var item in patient1.problems)
            {
                Console.WriteLine(item.problemName + " " + item.problemDescription + " " + item.problemDuration);
            }

        }
    }
}

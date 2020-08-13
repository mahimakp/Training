using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch objWatch = new Stopwatch();
            Stopwatch objWatch1 = new Stopwatch();
        

            Employee emp1 = new Employee();
            emp1.EmpId = "E0001";
            emp1.Name = "Mahima";

            Employee emp2 = new Employee();
            emp2.EmpId = "E0002";
            emp2.Name = "Ansh";

            Employee emp3 = new Employee();
            emp3.EmpId = "E0003";
            emp3.Name = "emp3";

            Employee emp4 = new Employee();
            emp4.EmpId = "E0004";
            emp4.Name = "emp4";

            Employee emp5 = new Employee();
            emp5.EmpId = "E0005";
            emp5.Name = "emp5";

            Employee emp6 = new Employee();
            emp6.EmpId = "E0006";
            emp6.Name = "emp6";

            Employee emp7 = new Employee();
            emp7.EmpId = "E0007";
            emp7.Name = "emp7";

            Employee emp8 = new Employee();
            emp8.EmpId = "E0008";
            emp8.Name = "emp8";

            Employee emp9 = new Employee();
            emp9.EmpId = "E0009";
            emp9.Name = "emp9";


            Dictionary<string, Employee> dictionary = new Dictionary<string, Employee>();

            dictionary.Add("1", emp1);
            dictionary.Add("2", emp2);
            dictionary.Add("3", emp3); 
            dictionary.Add("4", emp4); 
            dictionary.Add("5", emp5); 
            dictionary.Add("6", emp6);
            dictionary.Add("7", emp7);
            dictionary.Add("8", emp8);
            dictionary.Add("9", emp9);

            objWatch.Start();

            for (int i = 0; i < 100000; i++)
            {
                var record9 = dictionary["9"];

            }

            objWatch.Stop();

            var resultDictionary = objWatch.ElapsedMilliseconds.ToString();


            List<Employee> empList = new List<Employee>();
            
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);
            empList.Add(emp6);
            empList.Add(emp7);
            empList.Add(emp8);
            empList.Add(emp9);

            objWatch1.Start();

            for (int i = 0; i < 100000; i++)
            {
                var recordList9 = empList[8];

            }

            objWatch1.Stop();

            var resultList = objWatch1.ElapsedMilliseconds.ToString();


            Console.WriteLine(resultDictionary);
            Console.WriteLine(resultList);
            
        }
    }

    public class Employee
    {
        public string EmpId { get; set; }
        public string Name { get; set; }

    }
}

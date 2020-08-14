using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }

    }

    public class Address
    {
        public int customerId { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
    }
    class Program
    {

        
        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer() { id = 1, name = "Name1" });
            customers.Add(new Customer() { id = 2, name = "Name2" });
            customers.Add(new Customer() { id = 3, name = "Name3" }); 
            customers.Add(new Customer() { id = 4, name = "Name4" });

            List<Address> addresses = new List<Address>();

            addresses.Add(new Address()
            {
                customerId = 1,
                street1 = "Mumbai",
                street2 = "Mulund"
            });

            addresses.Add(new Address()
            {
                customerId = 2,
                street1 = "Mumbai",
                street2 = "Vashi"
            });


            Console.WriteLine("Query 1"); 
            
            var output = (from customer in customers
                          join address in addresses
                          on customer.id equals address.customerId
                          select new { 
                          
                              CustomerId = customer.id,
                              CustomerName = customer.name,
                              CustomerAddress = address.street1

                          }).ToList();


            foreach (var item in output)
            {

                Console.WriteLine("ID: " + item.CustomerId + " Name: " + item.CustomerName +" Street1: " + item.CustomerAddress);
            }


            Console.WriteLine("Query 2");

            var output2 = (from customer in customers
                           join address in addresses
                           on customer.id equals address.customerId into val
                           from address in val.DefaultIfEmpty()
                           select new
                           {

                               CustomerID = customer.id,
                               CustomerName = customer.name,
                               CustomerAddress = address != null ? address.street1 : "null"

                           }).ToList();


            foreach (var item in output2)
            {

                Console.WriteLine("ID: " + item.CustomerID + " Name: " + item.CustomerName + " Street1: " + item.CustomerAddress);
            }

            Console.Read();

        }
    }
}

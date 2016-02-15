using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John",
                Salary = 3500
            };
            SavingsCustomer savingsCustomer1 = new SavingsCustomer()
            { 
                ID = 201,
                Name = "Markus",
                Salary = 4000
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Insert(0, savingsCustomer1);
            //with insert i can choice position

            foreach (Customer c in customers)
            {
                Console.WriteLine("ID = " + c.ID + ", Name = " + c.Name + ", Salary = " + c.Salary);
            }

            Console.WriteLine();
            for (int i = 0; i < customers.Count; i++)
            {
                Customer c = customers[i];
                Console.WriteLine("ID = " + c.ID + ", Name = " + c.Name + ", Salary = " + c.Salary);
            }

            Console.WriteLine();
            Console.WriteLine("Index of customer 1 is: " + customers.IndexOf(customer1));
            Console.ReadLine();
        }
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        
        }

        public class SavingsCustomer : Customer
        {
        
        }
    }
}

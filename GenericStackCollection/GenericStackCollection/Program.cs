using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Zac",
                Gender = "Male"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Lisa",
                Gender = "Female"
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Braum",
                Gender = "Male"
            };

            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            //pop removes and ads item
            Customer c1 = stackCustomers.Pop();
            Console.WriteLine(c1.ID + " - " + c1.Name);
            Console.WriteLine("Items left in stack = " + stackCustomers.Count);

            Customer c2 = stackCustomers.Pop();
            Console.WriteLine(c2.ID + " - " + c2.Name);
            Console.WriteLine("Items left in stack = " + stackCustomers.Count);

            Console.WriteLine();

            //Peek doesnt remove item
            Customer C1 = stackCustomers.Peek();
            Console.WriteLine(C1.ID + " - " + C1.Name);
            Console.WriteLine("Items left in stack = " + stackCustomers.Count);

            //foreach (Customer c in stackCustomers)
            //{
            //    Console.WriteLine("Items left in stack = " + stackCustomers.Count);
            //    Console.WriteLine(c1.ID + " - " + c1.Name);
            //}

            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
}

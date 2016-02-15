using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 105,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 198,
                Name = "Pam",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 117,
                Name = "John",
                Salary = 3500
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            //Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);

            Console.WriteLine("Before sorting");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }

            //works same as code in next line
            //listCustomers.Sort(delegate(Customer c1, Customer c2) {return c1.ID.CompareTo(c2.ID); });
            listCustomers.Sort((x,y) => x.ID.CompareTo(y.ID));


            Console.WriteLine("After sorting");

            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }


            Console.ReadLine();
        

        }

        //private static int CompareCustomer(Customer x, Customer y)
        //{
        //    return x.ID.CompareTo(y.ID);
        //}
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}

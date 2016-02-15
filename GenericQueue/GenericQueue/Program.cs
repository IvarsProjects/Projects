using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
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

            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);


            //Deque will remove and return first item from list
            Customer c1 =  queueCustomers.Dequeue();
            Console.WriteLine(c1.ID + " - " + c1.Name);
            Console.WriteLine("Total items left in the Queue = " + queueCustomers.Count);

            Console.WriteLine();

            Customer c2 = queueCustomers.Dequeue();
            Console.WriteLine(c2.ID + " - " + c2.Name);
            Console.WriteLine("Total items left in the Queue = " + queueCustomers.Count);

            Console.WriteLine();

            Customer c3 = queueCustomers.Dequeue();
            Console.WriteLine(c3.ID + " - " + c3.Name);
            Console.WriteLine("Total items left in the Queue = " + queueCustomers.Count);

            Console.WriteLine();
            //Peak returns first item but it doesnt remove it. You cant repeat this meyhod because it will return first item!!!
            Customer c = queueCustomers.Peek();
            Console.WriteLine("Peak - " + c.ID + " - " + c.Name);


            Console.WriteLine();
            Console.WriteLine("Free list:");
            foreach (Customer customer in queueCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            Console.WriteLine();

            if (queueCustomers.Contains(customer5))
            {
                Console.WriteLine("Customer exists!");
                Console.WriteLine("ID = {0}, Name = {1}", customer5.ID, customer5.Name);
            }
            else
            {
                Console.WriteLine("Customer doesnt exist!");
            }



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

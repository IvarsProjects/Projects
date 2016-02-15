using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
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

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            //for checking if key is not existing already
            if (!dictionaryCustomers.ContainsKey(customer1.ID))
            {
                dictionaryCustomers.Add(customer1.ID, customer1);
            }

            //for checking if key exists
            if (dictionaryCustomers.ContainsKey(100))
            {
                Customer checkIfIdExists = dictionaryCustomers[100];
            }
            Customer customerSearchId = dictionaryCustomers[103];
            //System.Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customerSearchId.ID, customerSearchId.Name, customerSearchId.Salary);
            //Console.WriteLine();

            //(works same as code in next line) foreach(KeyValuePair<int, Customer> CustomerKeyValuePair in dictionaryCustomers)
            foreach (var CustomerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + CustomerKeyValuePair.Key);        
                Customer cust = CustomerKeyValuePair.Value;
                Console.WriteLine ("ID = {0}, Name = {1}, Salary = {2} " , cust.ID ,cust.Name, cust.Salary);
                Console.WriteLine("-----------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Keys: ");
            foreach (var key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();
            Console.WriteLine("Values: ");
            foreach (Customer Value in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2} ", Value.ID, Value.Name, Value.Salary);
                Console.WriteLine("-----------------------------------------");
            }
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}

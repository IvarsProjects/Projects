using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAList
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Main
            #region part1
            List<int> numbers = new List<int>() { 1, 6, 4, 8, 3, 7, 9, 2, 5 };

            //Console.WriteLine("Numbers before sorting");
            foreach (int number in numbers)
            {
               // Console.WriteLine(number);
            }

            numbers.Sort();
            //Console.WriteLine("Numbers after sorting");
            foreach (int number in numbers)
            {
               // Console.WriteLine(number);
            }

            //Console.WriteLine("Numbers reverse");
            numbers.Reverse();

            foreach (int number in numbers)
            {
               // Console.WriteLine(number);
            }
            //Console.WriteLine();
            //Console.WriteLine("Alphabets");

            List<string> alphabets = new List<string>() { "O", "A", "K", "H", "C", "B" };
            
            alphabets.Sort();

            foreach (string simbol in alphabets)
            {
               // Console.WriteLine(simbol);
            }
            #endregion

            #region customers
            Customer customer1 = new Customer()
            {
                ID = 107,
                Name = "Adam",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Zac",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 199,
                Name = "John",
                Salary = 2000
            };
            #endregion

            #region list
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
            #endregion

            #region sortingBySalary
            Console.WriteLine("Before sorting");
            foreach (Customer c1 in listCustomers)
            {
                Console.WriteLine(c1.Salary);
            }


            listCustomers.Sort();

            Console.WriteLine();
            Console.WriteLine("Afetr sorting");
            foreach (Customer c1 in listCustomers)
            {
                Console.WriteLine(c1.Salary);
            }

            Console.WriteLine();

            listCustomers.Reverse();

            Console.WriteLine("Reverse sorting");
            foreach (Customer c1 in listCustomers)
            {
                Console.WriteLine(c1.Salary);
            }

            Console.WriteLine();
            #endregion

            #region sortingByNames
            Console.WriteLine("Names before sorting");

            Console.WriteLine();

            foreach (Customer c1 in listCustomers)
            {
                Console.WriteLine(c1.Name);
            }

            SortByName sortbyname = new SortByName();
            listCustomers.Sort(sortbyname);

            Console.WriteLine();

            Console.WriteLine("Names after sorting");

            Console.WriteLine();

            foreach (Customer c1 in listCustomers)
            {
                Console.WriteLine(c1.Name);
            }
#endregion
            #endregion

            Console.ReadLine();
        }

    }
    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    
    }

    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else 
            //    return 0;

            //This code worsk same as code in next line
            return this.Salary.CompareTo(other.Salary);
            //I can sort by Name and ID as well. 


        }
    }
}

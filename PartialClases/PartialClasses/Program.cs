using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCustomerInfo.CreateCustomer();
            Console.ReadLine();
        }
    }
    public class Customer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }


    
    }
}

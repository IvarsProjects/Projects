using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public class PrintCustomerInfo
    {
        public static void CreateCustomer()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Adam";
            C1.LastName = "Bond";
            string CustomerOnefullName = C1.GetFullName();
            Console.WriteLine(CustomerOnefullName);

            Console.WriteLine();

            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "Richard";
            C2.LastName = "Mat";
            string CustomerTwoFullName = C2.GetFullName();
            Console.WriteLine(CustomerTwoFullName);
        }
    }
}

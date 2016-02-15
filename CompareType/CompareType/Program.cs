using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareType
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator <string>.areEquals("a", "a");
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            Console.WriteLine();

            Override.toString();

            Console.ReadLine();
        }
    }
    public class Calculator<T>
    {
        public static bool areEquals(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
    public static class Override
    {

        public static void toString ()
        {
            int number = 10;
            Console.WriteLine(number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Braun";

            Console.WriteLine(C1.ToString());
            Console.WriteLine(Convert.ToString(C1));
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + ", " + LastName;
        } 
    }
}

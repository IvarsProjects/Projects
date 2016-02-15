using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type T = Type.GetType("Reflection.Customer");
            //Type T = typeof(Customer);   
            
            Customer C1 = new Customer();
            Type T = C1.GetType();

            //Can use any of 3 ways to get type.

            Console.WriteLine("Full name is: " + T.FullName);
            Console.WriteLine("Name is: " + T.Name);
            Console.WriteLine("Namespace is: " + T.Namespace);

            Console.WriteLine();

            Console.WriteLine("Properties in Customer class");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Methods in Customer class");
            MethodInfo[] methodods = T.GetMethods();
            foreach (MethodInfo method in methodods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Constructors in Customer class");
            ConstructorInfo[] construcors = T.GetConstructors();
            foreach (ConstructorInfo construcor in construcors)
            {
                Console.WriteLine(construcor.ToString());
            }

            Console.ReadLine();

        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string NAME)
        {
            this.Id = ID;
            this.Name = NAME;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("Id: {0}", Id);        
        }
        public void printName()
        {
            Console.WriteLine("Name: {0}", Name);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClases
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass obj = new PartialClass ();
            obj.Method1();
            obj.Method2();
            
            Console.ReadLine();
        }
    }
    public interface IEmployee
    {
        void EmployeeMethod();
    }
    public interface ICustomer
    {
        void CustomerMethod();
    }
}

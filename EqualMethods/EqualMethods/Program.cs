using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region comments
            /*
            int i = 10;
            int j = 10;

            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

            Console.WriteLine();
             

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;

            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));
            */
            #endregion;

            Customer C1 = new Customer();
            C1.FirstName = "Sam";
            C1.LastName = "Bond";

            Customer C2 = C1;

            Customer C3 = new Customer();
            C3.FirstName = "Sam";
            C3.LastName = "Bond";

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));

            Console.WriteLine();

            Console.WriteLine(C1 == C3);
            Console.WriteLine(C1.Equals(C3));

            Console.WriteLine();

            Console.WriteLine(C2 == C3);
            Console.WriteLine(C2.Equals(C3));

            Console.ReadLine();
        }
    }

    public enum Direction
    { 
        East = 1,
        West = 2,
        North = 3,
        South = 4 
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(!(obj is Customer))
            {
                return false;
            }
            return this.FirstName == ((Customer)obj).FirstName &&
                this.LastName == ((Customer)obj).LastName;
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
        

    }
}

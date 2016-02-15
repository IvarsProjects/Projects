using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = null;
            string str = Convert.ToString(C1);
            Console.WriteLine(str);

            Console.WriteLine();

            string userString = "C#";
            userString += " Video";
            userString += " Tutorial";
            userString += " For";
            userString += " Beginers";

            Console.WriteLine(userString);

            Console.WriteLine();

            StringBuilder builderString = new StringBuilder("C#");
            builderString.Append(" Video");
            builderString.Append(" Tutorial");
            builderString.Append(" For");
            builderString.Append("Beginers");

            Console.WriteLine(builderString.ToString());

            Console.WriteLine();

            string randomString = string.Empty;

            for (int i = 0; i < 30; i++)
            {
                randomString += i.ToString() + " ";
            }
            Console.WriteLine(randomString);

            Console.ReadLine();

        }
    }
    public class Customer
    {
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;


namespace ModifiersForTypesAndAtributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new List<int>(){10, 20,30});
            Console.ReadLine();
        }
    }

    public class calculator
    {
        [Obsolete("Please use new version of calculator (Add(List <int> Numbers))", true)]
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        public static int Add(List <int> Numbers)
        {
            Numbers.Add(12);
            Numbers.Add(72);

            int Sum = 0;
            foreach (int number in Numbers)
            {
                Sum = Sum + number;
            }
            return Sum;
        }
    }
}

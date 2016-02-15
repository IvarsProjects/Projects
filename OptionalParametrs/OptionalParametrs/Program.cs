using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//needed for 4th add!
using System.Runtime.InteropServices;

namespace OptionalParametrs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20);
            AddNumbers2(10, 20, new int[] {30, 40});
            AddNumbers3(10, 20, new int[] {30, 40, 50});
            AddNumbers4(10, 20);
            //Test(1, c: 2);
            Console.ReadLine();
        }

        #region FirstAdd
        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Result 1 is: " + result);
        }
        #endregion

        #region SecondAdd

        public static void AddNumbers2(int firstNumber, int secondNumber)
        {
            AddNumbers2(firstNumber, secondNumber, null);
        }

        public static void AddNumbers2(int firstNumber, int secondNumber, int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Result 2 is: " + result);
        }

        #endregion

        #region ThirdAdd

        public static void AddNumbers3(int firstNumber, int secondNumber, int[] restOfNumbers = null)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Result 3 is: " + result);
        }

        public static void Test(int a, int b = 20, int c = 30)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        
        }

        #endregion

        #region FourthAdd

        public static void AddNumbers4(int firstNumber, int secondNumber,[Optional] int[] restOfNumbers )
        {
        
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Result 4 is: " + result);
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;
using AssamblyTwo;

namespace InternalModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyOneClassII.SampleMethod();
            Console.ReadLine ();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethods
{
    public partial class PartialClass
    {
        partial void PartialMethod(int i);

        partial void PartialMethod(int i)
        {
            Console.WriteLine("Partial Method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Public method");
            PartialMethod(1);
        }
    }
}

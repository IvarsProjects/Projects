using System;
using AssemblyOne;

namespace AssamblyTwo
{
    public class AssemblyTwoClassI : AssemblyOneClassI
    {
        public void PrintMethod()
        {
            AssemblyOneClassI A2 = new AssemblyOneClassI ();
            base.Password = 123;

            AssemblyTwoClassI A3 = new AssemblyTwoClassI();
            A3.Password = 321;
        }
    }
}

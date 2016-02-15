using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI
    {
        public void test()
        {
            AssemblyOneClassI instance = new AssemblyOneClassI();
            instance.print ();
        }
    }
}

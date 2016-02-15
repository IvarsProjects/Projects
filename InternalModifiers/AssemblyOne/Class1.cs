using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        internal int ID = 101;
        protected internal int Password = 123;
    }

    public static class AssemblyOneClassII
    {
        public static void SampleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.WriteLine(A1.ID);
            Console.WriteLine(A1.Password);
        }
    }
    public class AssemblyOneClassIII : AssemblyOneClassI
    {
        public void getPassword()
        {
            AssemblyOneClassI B1 = new AssemblyOneClassI();
            Console.WriteLine (B1.Password);
        }
    }
}

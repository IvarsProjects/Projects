using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndMembers
{
    public class Customer
    {

        #region Fields
        private int _id;
        private string _firstName;
        private string _lastName;

        #endregion

        #region Properties 
        protected int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        protected string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        protected string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        #endregion

        #region Methods

        public void GetCustomersInfo()
        {
           Console.WriteLine(_firstName + " " + this._lastName);
           Console.WriteLine(Id);
        }

        #endregion

    }

    public class CorporateCustomer : Customer
    { 
        public static void Customer_1 ()
        {
            CorporateCustomer Customer1 =  new CorporateCustomer ();
            Customer1.Id = 01;
            Customer1.FirstName = "Andy";
            Customer1.LastName = "Brown";
            Customer1.GetCustomersInfo(); 
            //can use also "this." or "base." to access protected values
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            CorporateCustomer.Customer_1 ();
            
            Console.ReadLine();
        }
    }
}

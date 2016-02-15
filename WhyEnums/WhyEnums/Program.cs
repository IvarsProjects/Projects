using System;

namespace WhyEnums
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Customers[] people = new Customers[3];
			people [0] = new Customers {Name = "Ivars", Gender = genderEnum.Male };
			people [1] = new Customers { Name = "Vayne", Gender = genderEnum.Female };
			people [2] = new Customers { Name = "Sam", Gender = genderEnum.Unknown }; 

			foreach (Customers customer in people)
			{
				Console.WriteLine ("Customers name is: {0} and gender is: {1}.", customer.Name, getGender(customer.Gender));
			}
			Console.ReadLine ();
		}
		public static string getGender (genderEnum gender)
		{
			switch (gender)
			{
			case genderEnum.Unknown:
					return "Unknown";
			case genderEnum.Male:
					return "Male";
			case genderEnum.Female:
					return "Female";
				default: 
					return "Invalid data detected";
			}
		}
	}

	public enum genderEnum
	{
		Male,
		Female,
		Unknown
	}



	public class Customers
	{
		public string Name { get; set;}
		public genderEnum Gender { get; set;}
	}
}

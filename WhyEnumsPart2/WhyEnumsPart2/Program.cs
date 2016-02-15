using System;

namespace WhyEnumsPart2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			short[] Values = (short[])Enum.GetValues (typeof(GenderEnum));
			foreach (short value in Values) 
			{
				Console.WriteLine (value);
			}

			Console.WriteLine ();

			string[] Names = Enum.GetNames (typeof(GenderEnum));
			foreach (string name in Names) 
			{
				Console.WriteLine (name);
			}

			Console.ReadLine ();
		}
	}

	public enum GenderEnum : short
	{
		Unknown = 1, Male, Female
	}

//	public static class Seasons
//	{
//		public static void seasons ()
//		{
//			GenderEnum gender = (GenderEnum)SeasonsEnum.Summer;
//			Console.WriteLine (gender);
//		}
//	}
//	public enum SeasonsEnum
//	{
//		Winter = 1,
//		Spring = 2,
//		Summer = 3
//	} 

} 

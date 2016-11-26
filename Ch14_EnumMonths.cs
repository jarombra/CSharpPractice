using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumMonths
{
	
	// Defining our months enumeration.

	public enum Months { January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, 
		July = 7, August = 8, September = 9, October = 10, November = 11, December = 12 };

	class Program
	{
		static void Main(string[] args)
		{

			// Greeting.

			Console.WriteLine ("Please provide the numeric value of a month.");

			// Get user input.

			string monthAsString = Console.ReadLine ();
			int monthNum = Convert.ToInt32 (monthAsString);

			// Check input range.

			if (monthNum > 0 && monthNum <= 12) {

				// Then print out the correct month name.

				Months specificMonth = (Months)monthNum;
				Console.WriteLine (specificMonth);
			} else {
				Console.WriteLine ("There aren't " + monthAsString + " months in the year!");
			}
		}
	}
}

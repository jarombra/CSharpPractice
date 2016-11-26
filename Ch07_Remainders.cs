using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine ("Let's calculate for a quotient and remainder.");

			Console.WriteLine ("Please enter the divident (number to be divided):");
			string dividendAsString = Console.ReadLine ();
			int dividend = Convert.ToInt32 (dividendAsString);

			Console.WriteLine ("Please enter the divisor (number to divide by):");
			string divisorAsString = Console.ReadLine ();
			int divisor = Convert.ToInt32 (divisorAsString);

			int quotient = dividend / divisor;
			int remainder = dividend % divisor;

			Console.WriteLine (dividend + " divided by " + divisor + " equals (in integers) " + quotient + " with a remainder of " + remainder);
		}
	}
}

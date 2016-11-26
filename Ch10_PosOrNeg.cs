using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosOrNeg
{
	class Program
	{
		static void Main(string[] args)
		{
			// Greeting.

			Console.WriteLine ("Hi, this is a program that checks to see if a multiplication result is postitive or negative, ");
			Console.WriteLine ("without actually doing any math!");

			// User prompt and input.

			Console.WriteLine ("We need two numbers first.");
			Console.WriteLine ("Please enter the multiplier.");
			string firstNumAsText = Console.ReadLine ();
			float firstNum = Convert.ToSingle (firstNumAsText);

			Console.WriteLine ("Please enter the multiplicand.");
			string secondNumAsText = Console.ReadLine ();
			float secondNum = Convert.ToSingle (secondNumAsText);

			// Conditional operation time.

			if ((firstNum > 0 && secondNum > 0) || (firstNum < 0 && secondNum < 0))
				Console.WriteLine ("This will be a positive multiplication result.");
			else if (firstNum == 0 || secondNum == 0)
				Console.WriteLine ("You got a zero in there, so the result is 0.");
			else
				Console.WriteLine ("One of the numbers is negative, so the result will be negative.");
		}
	}
}

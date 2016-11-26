using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			// Greeting.

			Console.WriteLine ("Welcome to the basic calculator");

			// Get first value.

			Console.WriteLine ("Enter the first value.");
			string firstValueAsText = Console.ReadLine ();
			float a = Convert.ToSingle (firstValueAsText);

			// Get second value.

			Console.WriteLine ("Enter the second value.");
			string secondValueAsText = Console.ReadLine ();
			float b = Convert.ToSingle (secondValueAsText);

			// Prompt operation.

			Console.WriteLine ("Enter '+', '-', '*', '/', '^'.");
			string operation = Console.ReadLine ();

			// Establishing the result and error variables for later.

			float result = 0;
			string error = "ERROR";

			// Define switch operations.

			switch (operation)
			{
			case "+":
				result = a + b;
				break;
			case "-":
				result = a - b;
				break;
			case "*":
				result = a * b;
				break;
			case "/":
				result = a / b;
				break;
			case "^":
				result = (float)Math.Pow(a, b);
				break;
			default:
				Console.WriteLine (error);
				break;
			}

			// Print the result.

			Console.WriteLine (a + " " + operation + " " + b + " = " + result);
			Console.ReadKey ();
		}
	}
}

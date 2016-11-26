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

			Console.WriteLine ("Welcome to calculator.");
			Console.WriteLine ("Enter 'Exit' to stop.");

			// Persistent loop with an exit option.

			while (true)
			{

				// Get three input values from user, separated by spaces.

				Console.Write ("Input two values with an operation, with spaces between.");

				// Get values from user.

				string text = Console.ReadLine ();

				// Loop exit option.

				if(text == "exit" || text == "Exit")
					break;

				string[] parts = text.Split (' ');
				float value1 = Convert.ToSingle (parts [0]);
				string operation = parts [1];
				float value2 = Convert.ToSingle (parts [2]);

				// Establish the variable to store the result,
				// initialized to zero, to be updated by the computation.

				float result = 0;

				// Switch between operations depending on the symbol input.

				switch (operation) 
				{
				case "+":
					result = value1 + value2;
					break;
				case "-":
					result = value1 - value2;
					break;
				case "*":
					result = value1 * value2;
					break;
				case "/":
					result = value1 / value2;
					break;
				case "%":
					result = value1 % value2;
					break;
				case "^":
					result = (float)Math.Pow (value1, value2);
					break;
				default:
					Console.WriteLine ("ERROR");
					break;
				}

				// Print out the result.

				Console.WriteLine (value1 + " " + operation + " " + value2 + " = " + result);
			}
		}
	}
}

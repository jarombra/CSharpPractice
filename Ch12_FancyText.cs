using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyText
{
	class Program
	{
		static void Main(string[] args)
		{

			// This should produce a matrix of +'s, like so:
			// ++++++++++ of five lines.

			for(int row = 0; row < 5; row++)
			{
				for (int plus = 0; plus < 10; plus++) {
					Console.Write ("+");
				}
				Console.WriteLine (); // This makes it wrap around to the beginning again.
			}

			// This should produce a slope of *'s, like so:
			// *
			// **
			// *** ...so on until it reaches 10.

			for (int row = 0; row < 10; row++) {
				for (int asterisk = 0; asterisk < row + 1; asterisk++) {
					Console.Write ("*");
				}
				Console.WriteLine ();
			}

			// This should produce a pyramid of ^'s, like so:
			//   ^
			//  ^^^
			// ^^^^^ ...so on until the fifth line.
			//
			// Check out this pattern:
			// ROW      #SPACES      #STARS
			// 0        4            1
			// 1        3            3
			// 2        2            5
			// 3        1            7
			// 4        0            9
			// n        5 - n - 1    n * 2 + 1

			// First parent loop goes row by row.

			for (int row = 0; row < 5; row++) {

			// First child loop prints out correct number of spaces.

				for (int space = 0; space < 5 - row -1; space++) {
					Console.Write (" ");
				}

			// Second child loop prints out correct number of ^'s.

				for (int chevron = 0; chevron < row * 2 + 1; chevron++) {
					Console.Write ("^");
				}
				Console.WriteLine ();
			}

			// Wait for the user to respond before closing.

			Console.ReadKey ();
		}
	}
}

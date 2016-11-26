using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			
			// Looking at each element in a jagged array.

			int[][] matrix = new int[4][];
			matrix [0] = new int[2];
			matrix [1] = new int[6];
			matrix [2] = new int[8];
			matrix [3] = new int[3];

			for (int row = 0; row < matrix.Length; row++) {
				for (int column = 0; column < matrix [row].Length; column++) {

					// Print each item in the row seperated by spaces.

					Console.Write (matrix [row] [column] + " ");
				}

				// Rows separated by lines.

				Console.WriteLine ();
			}

			// Blank line, to seperate from the next shindig.

			Console.WriteLine ();

			// Looking at each element in a square multidimensional array.

			int[,] multiMatrix = new int[4,4];
			multiMatrix [0,0] = 1;
			multiMatrix [0,1] = 2;
			multiMatrix [0,2] = 3;
			multiMatrix [0,3] = 4;
			multiMatrix [1,0] = 5;
			multiMatrix [1,1] = 6;
			multiMatrix [1,2] = 7;
			multiMatrix [1,3] = 8;
			multiMatrix [2,0] = 9;
			multiMatrix [2,1] = 10;
			multiMatrix [2,2] = 11;
			multiMatrix [2,3] = 12;
			multiMatrix [3,0] = 13;
			multiMatrix [3,1] = 14;
			multiMatrix [3,2] = 15;
			multiMatrix [3,3] = 16;

			// GetLength gives back the size of the multi-dimensional array for a specific index.

			for(int row = 0; row < multiMatrix.GetLength(0); row++)
			{
				for (int column = 0; column < multiMatrix.GetLength (1); column++) {
					Console.Write (multiMatrix [row, column] + " ");
				}
				Console.WriteLine();
			}

			// Blank line, to seperate from the next shindig.

			Console.WriteLine ();

			// Here's some stuff on using foreach loops with arrays

			int[] stuff = new int[] {-8, 8, 0, 1, 4, 6, 7, -20, 9, 9};

			int total = 0;

			// Determining the minimum value.

			int currentMin = Int32.MaxValue;
			foreach (int values in stuff) {
				if (values < currentMin) {
					currentMin = values;
				}
			}

			Console.WriteLine ("Minimum: " + currentMin);

			// Determine the total and average value.

			foreach (int values in stuff) {
				total += values;
			}

			float average = (float)total / stuff.Length;
			Console.WriteLine ("Stuff totals to " + total + " and averages to " + average);
		}
	}
}

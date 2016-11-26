using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create first array, then define second from first's length.

			int[] firstArray = new int[] { 2, 4, 1, 6, 7 };
			int[] secondArray = new int[firstArray.Length];

			// Copy each index values from one the first array to the second.

			for (int index = 0; index < firstArray.Length; index++) {
				secondArray [index] = firstArray [index];
			}

			// Print out arrays.

			for (int index = 0; index < firstArray.Length; index++) {
				Console.Write (firstArray[index] + " ");
			}
			Console.WriteLine ();

			for (int index = 0; index < secondArray.Length; index++) {
				Console.Write (secondArray[index] + " ");
			}

			Console.ReadKey();

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{

	class Program
	{
		
		// The Main method calls three other methods:
		// First, GenerateNumbers creates an array.
		// Second method, Reverse flips the array indices.
		// Third method, PrintNumbers outputs the new array values.

		static void Main(string[] args)
		{
			int[] numbers = GenerateNumbers ();
			Reverse (numbers);
			PrintNumbers (numbers);
		}

		// Below and outside our Main method, but inside our class block,
		// The first method generates the array.

		static int[] GenerateNumbers()
		{
			int[] numbers = new int[10];

			for (int index = 0; index < 10; index++) {

				// One is added to the index to start at index 1, and not 0.
				// Otherwise, we could count down from 9 to 0, or whatever.

				numbers [index] = index + 1;
			}
			return numbers;
		}

		// The second method reverses the contents of a passed in array.

		static void Reverse(int[] numbers)
		{

			// Initialize one index at the start of the array, and another
			// at the end of the array. The index of the last item in the
			// array is the length of the array -1.

			int firstIndex = 0;
			int secondIndex = numbers.Length - 1;

			while (firstIndex < secondIndex) {

				// While swapping array values, a temporary variable is created
				// so the value will not be overwritten.

				int temp = numbers [firstIndex];
				numbers [firstIndex] = numbers [secondIndex];
				numbers [secondIndex] = temp;

				// Move on to the next pair of values.

				firstIndex++;
				secondIndex--;
			}
		}

		// The third method prints out the array. Although this is logically the
		// third step, the methods can be in any order in the class's code block.

		static void PrintNumbers(int[] numbers)
		{
			for (int index = 0; index < numbers.Length; index++) {
				Console.WriteLine (numbers [index]);
			}

			// Move down a line.

			Console.WriteLine ();
		}
	}
}

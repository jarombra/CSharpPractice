using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomDice
{
	class Program
	{
		static void Main(string[] args)
		{
			// Creates our object randomRoll as a member to the Random class.
			// By default Random objects use a parameter-less constructor,
			// hence the emply parentheses.
			// Classes are reference types, and stored on the heap.

			Random randomRoll = new Random ();

			// Simulate the rolls for the requested dice.

			Console.WriteLine ("Enter number of dice to roll: ");
			int diceCount = Convert.ToInt32 (Console.ReadLine ());

			// We now call the Next method, which is part of the Random class.
			// This method Next can be called on objects that are a member of the Random class,
			// which our object randomRoll is.
			// The +1 is because Next(6) returns 0 to 5.

			int total = 0;
			for (int index = 1; index <= diceCount; index++) {

				int roll = randomRoll.Next (6) + 1;
				total += roll;

				// If the loop is not on the last dice, print out a plus symbol after the roll value.
				// As an aside, if you wanted to start the loop at index = 0 as is conventional,
				// index would have to count up until it is simply < diceCount (not less than or equals),
				// and the printing plus symbols conditional below would have to be coded as
				// (index != diceCount -1) to adjust for the indexing since the loop 
				// would be starting at zero. But who rolls zero dice? So start the loop at 1.

				if (index != diceCount) {
					Console.Write (roll + "+");
				} else {

					// Write the last die roll.
					Console.Write (roll);
				}
			}

			// Print the total sum of all the dice rolls.

			Console.WriteLine ("=" + total);
			Console.ReadKey ();
		}
	}
}

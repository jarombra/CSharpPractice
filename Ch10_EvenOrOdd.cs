using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine ("Let's check to see if a number is even or odd.");
			Console.WriteLine ("Enter any number please.");
			string userNumAsText = Console.ReadLine ();
			float userNum = Convert.ToSingle (userNumAsText);

			if (userNum % 2 == 0)
				Console.WriteLine ("Your number is even.");
			else if (userNum % 2 == 1)
				Console.WriteLine ("Your number is odd.");
			else
				Console.WriteLine ("You didn't input an integer, did you.");
		}
	}
}

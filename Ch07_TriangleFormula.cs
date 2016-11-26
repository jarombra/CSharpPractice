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
			Console.WriteLine ("Let's calculate the area of a triangle.");

			Console.WriteLine ("Please enter the trangle's base length:");
			string baseAsString = Console.ReadLine ();
			float triBase = Convert.ToSingle (baseAsString);

			Console.WriteLine ("Please enter the trangle's height length:");
			string heightAsString = Console.ReadLine ();
			float triheight = Convert.ToSingle (heightAsString);

			float triArea = 0.5f * triBase * triheight;

			Console.WriteLine ("The area of the triangle is " + triArea);
		}
	}
}

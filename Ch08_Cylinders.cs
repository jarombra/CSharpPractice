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
			Console.WriteLine ("Let's calculate for the volume and surface area of a cylinder.");

			Console.WriteLine ("How tall is this cylinder?");
			string heightAsString = Console.ReadLine();
			float cylHeight = Convert.ToSingle (heightAsString);

			Console.WriteLine ("How wide is this cylinder?");
			string radiusAsString = Console.ReadLine();
			float cylRadius = Convert.ToSingle (radiusAsString);

			//Defining pi using the provided Math method.
			double pi = Math.PI;

			double cylVolume = pi * cylRadius * cylRadius * cylHeight;
			double cylSurfArea = 2 * pi * cylRadius * (cylRadius + cylHeight);

			Console.WriteLine (cylVolume + " is the volume of the cylinder.");
			Console.WriteLine (cylSurfArea + " is the surface area of the cyildner.");

			Console.WriteLine ("Have a nice day.");
		}
	}
}

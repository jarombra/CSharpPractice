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
			int a = 2;
			int b = 5;
			b = a;
			a = -3;
			Console.WriteLine ("Printing both " + a + " and " + b);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Boring reference for standard C# -integral- variable types.
namespace Variables
{
	class Program
	{
		static void Main(string[] args)
		{
			// -byte- type uses 1 byte.
			byte loByte = 0;
			byte upByte = 255;
			// -short- type uses 2 bytes.
			short loShort = -32768;
			short upShort = 32767;
			// -int- type uses 4 bytes.
			int loInt = -2147483648;
			int upInt = 2147483647;
			// -long- type uses 8 bytes.
			long loLong = -9223372036854775808;
			long upLong = 9223372036854775807;
			// -sbyte- type uses 1 bytes.
			sbyte loSbyte = -128;
			sbyte upSbyte = 127;
			// -ushort- type uses 2 bytes.
			ushort loUshort = 0;
			ushort upUshort = 65535;
			// -uint- type uses 4 bytes.
			uint loUint = 0;
			uint upUint = 4294967295;
			// -ulong- type uses 8 bytes.
			ulong loUlong = 0;
			ulong upUlong = 18446744073709551615;
			// -char- type uses 2 bytes.
			char character = 'ü';

			Console.WriteLine ("Printing a bunch of stuff here, showing the lower and upper limits of various variable types.");
			Console.WriteLine ("Lower-limit of the 'byte' variable type is " + loByte);
			Console.WriteLine ("Upper-limit of the 'byte' variable type is " + upByte);
			Console.WriteLine ("Lower-limit of the 'short' variable type is " + loShort);
			Console.WriteLine ("Upper-limit of the 'short' variable type is " + upShort);
			Console.WriteLine ("Lower-limit of the 'int' variable type is " + loInt);
			Console.WriteLine ("Upper-limit of the 'int' variable type is " + upInt);
			Console.WriteLine ("Lower-limit of the 'long' variable type is " + loLong);
			Console.WriteLine ("Upper-limit of the 'long' variable type is " + upLong);
			Console.WriteLine ("Lower-limit of the 'sbyte' variable type is " + loSbyte);
			Console.WriteLine ("Upper-limit of the 'sbyte' variable type is " + upSbyte);
			Console.WriteLine ("Lower-limit of the 'ushort' variable type is " + loUshort);
			Console.WriteLine ("Upper-limit of the 'ushort' variable type is " + upUshort);
			Console.WriteLine ("Lower-limit of the 'uint' variable type is " + loUint);
			Console.WriteLine ("Upper-limit of the 'uint' variable type is " + upUint);
			Console.WriteLine ("Lower-limit of the 'ulong' variable type is " + loUlong);
			Console.WriteLine ("Upper-limit of the 'ulong' variable type is " + upUlong);
			Console.Write (character);
			Console.Write (" is an example of any Unicode character (U+0000 to U+ffff), over 64,000 possible characters.");
		}
	}
}

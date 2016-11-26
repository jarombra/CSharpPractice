using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciSequence
{
	class Program
	{

		static void Main(string[] args)
		{
			for (int index = 1; index <= 10; index++)
			{
				Console.WriteLine(Fibonacci(index));
			}

			Console.ReadKey();
		}

		static ulong Fibonacci(int number)
		{
			if (number == 1) { return 1; }
			if (number == 2) { return 1; }

			return Fibonacci(number - 1) + Fibonacci(number - 2);
		}
	}
}

// When dealing with this kind of problem, it's usually useful to look at (by which I mean conceptualize) 
// what's on the stack with each recursive call.

// So, we're in our Main loop, index is 4 and we call Fibonacci(4).  Right at that point, 
// our stack looks like this:

// --------------------
// Fibonacci(4)
// --------------------
// Main
// --------------------

// OK, now we're in Fibonacci(4).  We check the two conditionals, neither is true, 
// so we get to the return statement: return Fibonacci(3) + Fibonacci(2).  Now the stack looks like this:

// -------------------
// Fibonacci(2)
// -------------------
// Fibonacci(4) -> return Fibonacci(3) + Fibonacci(2)
// -------------------
//	Main
// -------------------

// Why did I put Fibonacci(2) on the top of the stack and ignore (for now) Fibonacci(3)?  
// I made an arbitrary decision, which is the same thing the compiler will do - not to say that 
// it might arbitrarily choose to evaluate Fibonacci(2) sometimes and Fibonacci(3) other times; 
// it's just that whoever wrote the compiler said: we'll always evaluate the right-most operand first.  
// Or maybe they said we'll evaluate the left operand.  It doesn't really matter.

// We're in Fibonacci(2).  The second condition is met, so we just return 1.  
// That function call pops off the stack:

// -------------------
// Fibonacci(4) -> return Fibonacci(3) + 1
// -------------------
// Main
// -------------------


// Now for the left operand:

// -------------------
// Fibonacci(3)
// -------------------
// Fibonacci(4) -> return Fibonacci(3) + 1
// ------------------
// Main
// ------------------


// Fibonacci(3) fails on both conditions; we're at the return statement:

// -------------------
// Fibonacci(1)
// -------------------
// Fibonacci(3) -> return Fibonacci(2) + Fibonacci(1)
// -------------------
// Fibonacci(4) -> return Fibonacci(3) + 1
// ------------------
// Main
// ------------------


// Fibonacci(1) returns 1 and pops off the stack:

// -------------------
// Fibonacci(3) -> return Fibonacci(2) + 1
// -------------------
// Fibonacci(4) -> return Fibonacci(3) + 1
// ------------------
// Main
// ------------------


// Evaluate Fibonacci(2):

// -------------------
// Fibonacci(2)
// -------------------
// Fibonacci(3) -> return Fibonacci(2) + 1
// -------------------
// Fibonacci(4) -> return Fibonacci(3) + 1
// ------------------
// Main
// ------------------


// Fibonacci(2) returns 1 and pops off the stack:

// -------------------
// Fibonacci(3) -> return 1 + 1
// -------------------
// Fibonacci(4) -> return Fibonacci(3) + 1
// ------------------
// Main
// ------------------


// Fibonacci(3) returns 1+1 (or 2) and pops off the stack:

// -------------------
// Fibonacci(4) -> return 2 + 1
// ------------------
// Main
// ------------------


// So we finally get back to Main with a return value of 3, the fourth Fibonacci number.  
// There may come a time when you can look at a recursive function and intuit the end result, 
// but I still have to walk through them like this, step by step.

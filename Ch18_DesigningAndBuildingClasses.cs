using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Ideally the Color class and Ball class included in this script would be
// in their own files within the project or assembly. But for the purpose of
// keeping my own C# sketches organized, I'm putting them all together here.
namespace DesigningAndBuildingClasses
{

	class Program
	{
		/// <summary>
		/// Tests the Ball and Color classes.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			// Create two different balls of different colors and sizes.
			Ball bigRed = new Ball(new Color(255, 0, 0), 5);
			Ball littlePurple = new Ball(new Color(255, 0, 255), 3);

			// Throw the big red ball around a few times.
			bigRed.Throw();
			bigRed.Throw();
			bigRed.Throw();
			Console.WriteLine(bigRed.GetTimesThrown());

			// Keep throwing it, and make sure that the number of
			// times thrown keeps going up.
			bigRed.Throw();
			bigRed.Throw();
			Console.WriteLine(bigRed.GetTimesThrown());

			// Throws the little purple ball around.
			littlePurple.Throw();
			littlePurple.Throw();
			Console.WriteLine(littlePurple.GetTimesThrown());

			// Pop the little purple ball and make sure that the throw
			// count doesn't keep going up if the ball has been popped.
			littlePurple.Pop();
			littlePurple.Throw();
			Console.WriteLine(littlePurple.GetTimesThrown());

			Console.ReadKey();

		}
	}

	/// <summary>
	/// Represents a color as red, green, blue, and alpha components.
	/// Because RBGA values are 0 to 255, the byte type is perfect, as
	/// it defines a value from 0 to 255!
	/// </summary>
	public class Color
	{
		/// <summary>
		/// Stores the red component of a color.
		/// </summary>
		private byte red;

		/// <summary>
		/// Stores the green component of a color.
		/// </summary>
		private byte green;

		/// <summary>
		/// Stores the blue component of a color.
		/// </summary>
		private byte blue;

		/// <summary>
		/// Stores the alpha component of a color.
		/// </summary>
		private byte alpha;

		/// <summary>
		/// Creates a new color with all of the components specified.
		/// The 'this' keyword, we get access to the class's instance variable,
		/// avoiding name-hiding, and bypassing the method-scope
		/// of the constructor's parameters.
		/// </summary>
		public Color(byte red, byte green, byte blue, byte alpha)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = alpha;
		}

		/// <summary>
		/// Creates a new color with only red, green, and blue components
		/// specified. In this case, alpha will be 255, or completely
		/// opaque.
		/// </summary>
		public Color(byte red, byte green, byte blue)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = 255;
		}

		/// <summary>
		/// Returns the red component of this color.
		/// </summary>
		/// <returns></returns>
		public byte GetRed()
		{
			return red;
		}

		/// <summary>
		/// Sets the red component of this color.
		/// </summary>
		/// <param name="red"></param>
		public void SetRed(byte red)
		{
			this.red = red;
		}

		/// <summary>
		/// Returns the green component of this color.
		/// </summary>
		/// <returns></returns>
		public byte GetGreen()
		{
			return green;
		}

		/// <summary>
		/// Sets the green component of this color.
		/// </summary>
		/// <param name="green"></param>
		public void SetGreen(byte green)
		{
			this.green = green;
		}

		/// <summary>
		/// Returns the blue component of this color.
		/// </summary>
		/// <returns></returns>
		public byte GetBlue()
		{
			return blue;
		}

		/// <summary>
		/// Sets the blue component of this color.
		/// </summary>
		/// <param name="blue"></param>
		public void SetBlue(byte blue)
		{
			this.blue = blue;
		}

		/// <summary>
		/// Returns the alpha component of this color.
		/// </summary>
		/// <returns></returns>
		public byte GetAlpha()
		{
			return alpha;
		}

		/// <summary>
		/// Sets the alpha component of this color.
		/// </summary>
		/// <param name="alpha"></param>
		public void SetAlpha(byte alpha)
		{
			this.alpha = alpha;
		}

		/// <summary>
		/// Returns the grayscale value of this color, which
		/// is the average of the red, green, and blue components.
		/// </summary>
		/// <returns></returns>
		public byte GetGrayscale()
		{
			return (byte)((red + green + blue) / 3);
		}
	}

	/// <summary>
	/// Represents a ball, with a color and size. This also
	/// keeps track of the number of times the ball has been thrown.
	/// </summary>
	public class Ball
	{
		/// <summary>
		/// Stores the color of the ball.
		/// </summary>
		private Color color;

		/// <summary>
		/// Stores the radius/size of the ball. The radius is in
		/// generic units.
		/// </summary>
		private float radius;

		/// <summary>
		/// Keeps track of the number of times this ball has been thrown.
		/// </summary>
		private int timesThrown;

		/// <summary>
		/// Creates a new ball with a given size and color.
		/// </summary>
		/// <param name="color"></param>
		/// <param name="radius"></param>
		public Ball(Color color, float radius)
		{
			this.color = color;
			this.radius = radius;
			this.timesThrown = 0;
		}

		/// <summary>
		/// Pops the ball, changing it's size to 0.
		/// </summary>
		public void Pop()
		{
			radius = 0;
		}

		/// <summary>
		/// Throws the ball. This will increment the count
		/// of the number of times the ball has been thrown only
		/// if the ball has not been popped.
		/// </summary>
		public void Throw()
		{
			if (radius > 0)
			{
				timesThrown++;
			}
		}

		/// <summary>
		/// Returns the number of times that the ball has been thrown
		/// so far. This will be updated whenever the Throw method is
		/// called.
		/// </summary>
		/// <returns></returns>
		public int GetTimesThrown()
		{
			return timesThrown;
		}
	}
}

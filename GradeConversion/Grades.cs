using System;

namespace GradeConversion
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double percent;
			string input;

			Console.WriteLine("What is your grade percent mark?");
			input = Console.ReadLine();
			percent = double.Parse(input);

			if (percent < 0)
			{
				Console.WriteLine("Not possible");
			}
			else if (percent <= 39)
			{
				Console.WriteLine("You got an F");
			}
			else if (percent <= 49)
			{
				Console.WriteLine("You got a D");
			}
			else if (percent <= 59)
			{
				Console.WriteLine("You got a C");
			}
			else if (percent <= 69)
			{
				Console.WriteLine("You got a B");
			}
			else if (percent <= 100)
			{
				Console.WriteLine("You got an A");
			}
			else
			{
				Console.WriteLine("Not possible");
			
			}
		}
	}
}

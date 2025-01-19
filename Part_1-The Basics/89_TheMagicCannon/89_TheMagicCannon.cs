using System;
class Program
{
	static void Main()
	{
		for (int num = 1; num <= 100; num++)
		{
			if (num % 5 == 0 && num % 3 == 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine($"{num}: Electric and Fire");
			}
			else if (num % 5 == 0)
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine($"{num}: Electric");
			}
			else if (num % 3 == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"{num}: Fire");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine($"{num}: Normal");
			}
		}
	}
}
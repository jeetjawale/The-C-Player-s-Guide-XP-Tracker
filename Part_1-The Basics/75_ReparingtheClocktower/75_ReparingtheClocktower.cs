using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
		int number = Convert.ToInt32(Console.ReadLine());
		if (number % 2 == 0) {
			Console.WriteLine("Pendulum should tick to the left");
		}
		else {
			Console.WriteLine("Pendulum should tock to the right");
		}
    }
}
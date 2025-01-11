using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is the base of the triangle?");
        double triangleBase = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is the height of the triangle?");
        double triangleHeight = Convert.ToDouble(Console.ReadLine());
        double triangleArea = 0.5 * triangleBase * triangleHeight;
        Console.WriteLine("The area of the triangle is " + triangleArea);
    }
}
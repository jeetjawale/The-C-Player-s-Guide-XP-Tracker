using System;

class Program
{
    static void Main()
    {
        Console.Title = "The Defence of Consolas";

        Console.WriteLine("Enter the row of the target:");
        int targetRow = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the column of the target:");
        int targetCol = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($@"Deploying squads to row {targetRow} and column {targetCol-1}.");
        Console.WriteLine($@"Deploying squads to row {targetRow} and column {targetCol+1}.");
        Console.WriteLine($@"Deploying squads to row {targetRow-1} and column {targetCol}.");
        Console.WriteLine($@"Deploying squads to row {targetRow+1} and column {targetCol}.");

        Console.Beep();

    }
}
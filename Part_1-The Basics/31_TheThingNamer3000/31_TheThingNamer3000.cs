using System;
class Program
{
    static void Main()
    {
     Console.WriteLine("What kind of thing are we talking about?");  
     string thing = Console.ReadLine(); // This is the variable that will store thing's name
     Console.WriteLine("How would you descirbe it? Big? Azure? Tattered?");
     string description = Console.ReadLine(); // This is the variable that will store thing's description 
     string doom = "of Doom";
     string number = "3000";
     Console.WriteLine("The " +description+ " " +thing+ " " +doom+ " " +number+ "!");          
    }
}
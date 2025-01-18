using System;

class Program
{
    static void Main()
    {
        int user1;

        do
        {
            Console.Write("User 1, enter a number between 0 and 100: ");
            user1 = int.Parse(Console.ReadLine());

            if (user1 < 0 || user1 > 100)
            {
                Console.WriteLine("Invalid number. Please enter a n umber between 0 and 100.");
            }
        } while (user1 < 0 || user1 > 100);

        Console.Clear(); 

       
        int user2;
        Console.WriteLine("User 2, guess the number: ");

        do
        {
            user2 = int.Parse(Console.ReadLine());

            if (user2 < user1)
            {
                Console.WriteLine("The number is greater than your guess.");
                Console.Write("What is your next guess? ");
            }
            else if (user2 > user1)
            {
                Console.WriteLine("The number is less than your guess.");
                Console.Write("What is your next guess? ");
            }
        } while (user2 != user1);

        Console.WriteLine("You guessed the number!");
    }
}

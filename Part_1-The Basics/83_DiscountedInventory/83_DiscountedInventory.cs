using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("The following items are available:");
        Console.WriteLine("1 - Rope");
        Console.WriteLine("2 - Torches");
        Console.WriteLine("3 - Climbing Equipment");
        Console.WriteLine("4 - Clean Water");
        Console.WriteLine("5 - Machete");
        Console.WriteLine("6 - Canoe");
        Console.WriteLine("7 - Food Supplies");

        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("What number do you want to see the price of? ");
        int itemNumber = Convert.ToInt32(Console.ReadLine());

        int price;
        string itemName;

        switch (itemNumber)
        {
            case 1:
                price = 10;
                itemName = "Rope";
                break;
            case 2:
                price = 15;
                itemName = "Torches";
                break;
            case 3:
                price = 25;
                itemName = "Climbing Equipment";
                break;
            case 4:
                price = 1;
                itemName = "Clean Water";
                break;
            case 5:
                price = 20;
                itemName = "Machete";
                break;
            case 6:
                price = 200;
                itemName = "Canoe";
                break;
            case 7:
                price = 1;
                itemName = "Food Supplies";
                break;
            default:
                price = 0;
                itemName = "Invalid choice";
                break;
        }

        string myname = "jeet";
        if (name == myname)
        {
            price = price / 2;
        }

        Console.WriteLine($"{itemName} costs {price} gold");
    }
}
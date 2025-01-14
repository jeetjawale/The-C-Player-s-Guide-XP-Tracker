using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name king");
        string name = Console.ReadLine();
        
        Console.WriteLine("No.of Estates");
        int estateCount = Convert.ToInt32(Console.ReadLine());
        int totalEstate = estateCount * 1;
        
        Console.WriteLine("No.of Duchies");
        int duchyCount = Convert.ToInt32(Console.ReadLine());
        int totalDuchy = duchyCount * 3;
        
        Console.WriteLine("No.of Provinces");
        int provinceCount = Convert.ToInt32(Console.ReadLine());
        int totalProvince = provinceCount * 6;
        
        int totalScore = totalEstate+totalDuchy+totalProvince;
        
        Console.WriteLine($"{name}, you scored {totalScore} points.");
    }
}
using Systeml

class Program
{
    static void Main()
    {
        Console.WriteLine("How many chocolate eggs were gathered today?");

        int eggCount = Convert.ToInt32(Console.ReadLine());


        int forSisters = eggCount / 4;
        int forDuckbear = eggCount % 4;

        Console.WriteLine("Each sister gets " + forSisters + ".");
        Console.WriteLine("The duckbear gets " + forDuckbear + ".");
    }
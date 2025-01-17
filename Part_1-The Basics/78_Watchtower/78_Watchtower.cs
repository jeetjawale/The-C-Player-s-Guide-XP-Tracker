using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter value of x");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of y");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x>0 && y>0){
            Console.WriteLine("The enemy is to the North-East");
        }
        else if (x>0 && y<0){
            Console.WriteLine("The enemy is to the South-East");
        }
        else if (x<0 && y>0){
            Console.WriteLine("The enemy is to the North-West");
        }
        else if (x<0 && y<0){
            Console.WriteLine("The enemy is to the South-West");
        }
        else if (x==0 && y>0){
            Console.WriteLine("The enemy is to the North");
        }
        else if (x==0 && y<0){
            Console.WriteLine("The enemy is to the South");
        }
        else if (x>0 && y==0){
            Console.WriteLine("The enemy is to the East");
        }
        else if (x<0 && y==0){
            Console.WriteLine("The enemy is to the West");
        }
        else{
            Console.WriteLine("The enemy is at your location");
        }
    }
}
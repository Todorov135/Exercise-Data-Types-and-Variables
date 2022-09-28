using System;

namespace _07.Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int WATHER_TANK_CAPACITY = 255;

            int numberOfLines = int.Parse(Console.ReadLine());
            int currentCapacity = WATHER_TANK_CAPACITY;

            for (int i = 0; i < numberOfLines; i++)
            {
                int addedQuantity = int.Parse(Console.ReadLine());

                

                if (currentCapacity - addedQuantity >= 0)
                {
                    currentCapacity -= addedQuantity; 
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }

            int inTankQuantity = WATHER_TANK_CAPACITY - currentCapacity;
            Console.WriteLine(inTankQuantity);

          
        }
    }
}

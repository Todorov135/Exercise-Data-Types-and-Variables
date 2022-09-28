using System;

namespace _10.Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());            
            int distance = int.Parse(Console.ReadLine());
            int exhaustedPower = int.Parse(Console.ReadLine());
            int pokedTarget = 0;
            int powerDecreesing = power;

            while (distance <= power)
            {
                pokedTarget++;
                power -= distance;
                if (powerDecreesing  * 0.5 == power && exhaustedPower > 0)
                {
                    power /= exhaustedPower;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(pokedTarget);

        }
    }
}

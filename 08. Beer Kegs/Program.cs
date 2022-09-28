using System;

namespace _08.Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            double maxVolume = double.MinValue;
            string biggestKeg = "";

            for (int i = 1; i <= inputLines; i++)
            {
                string kegName = Console.ReadLine();    
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                // π* r^2 * h

                double kegVolume = Math.PI * Math.Pow(radius, 2) * height;
                if (kegVolume > maxVolume)
                {
                    maxVolume = kegVolume;
                    biggestKeg = kegName;

                }

                

            }
            Console.WriteLine(biggestKeg);
            
        }
    }
}

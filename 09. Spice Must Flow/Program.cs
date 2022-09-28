using System;

namespace _09.Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int starterExtract = int.Parse(Console.ReadLine());
            int extracted = starterExtract;
            int sumOfExtract = 0;
            int dayCounter = 0;
            const int WORKER_CONSUME = 26;
            const int DAILY_CONSUME_OF_FEILD = 10;
            const int MINIMUM_FEILD_SPICE = 100;

            while (extracted >= MINIMUM_FEILD_SPICE)
            {
                sumOfExtract += extracted - WORKER_CONSUME;
             
                dayCounter++;
                extracted = extracted - DAILY_CONSUME_OF_FEILD;
                if (extracted < MINIMUM_FEILD_SPICE)
                {
                    sumOfExtract -= WORKER_CONSUME;
                }
            }
            
            Console.WriteLine(dayCounter);
            Console.WriteLine(sumOfExtract);
        }
    }
}

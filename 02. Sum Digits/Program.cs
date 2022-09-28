using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;

            while (input != 0)
            {
            int currentNum = input;
                currentNum %= 10;

                sum += currentNum;

                input /= 10;



            }
            Console.WriteLine(sum); 
        }
    }
}

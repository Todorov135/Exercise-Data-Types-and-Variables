using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += (int)input;

            }
            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}

using System;

namespace _01.Integer_Operations

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int divide = int.Parse(Console.ReadLine());
            int multiply = int.Parse(Console.ReadLine());

            int total = (first + second) / divide * multiply;

            Console.WriteLine(total);
        }
    }
}

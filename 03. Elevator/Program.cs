using System;


namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = (double)persons / capacity;

            Console.WriteLine(Math.Ceiling(courses));
            
        }
    }
}

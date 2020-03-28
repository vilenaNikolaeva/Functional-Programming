using System;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> prints = n => Console.WriteLine($"Sir {n}");
            Console.ReadLine()
                .Split(" ")
                .ToList()
                .ForEach(prints);

           

        }
    }
}

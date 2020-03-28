using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse);

            var divisibleNum = int.Parse(Console.ReadLine());

            Predicate<int> divOperatin = n => n % divisibleNum == 1;
            Func<int, bool> result = x => divOperatin(x);
            numbers = numbers.Where(result).Reverse();

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 10
            //odd
            //1 3 5 7 9
            var sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var command = Console.ReadLine();
            var result = new List<int>();

            Predicate<int> oddNum = n => n % 2 == 1;
            Predicate<int> evenNum = n => n % 2 == 0;

            Predicate<int> predicate = command == "odd"
                ? oddNum : evenNum;
            
            for (int i = sequence[0]; i <= sequence[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}

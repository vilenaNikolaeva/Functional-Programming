using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());

            Predicate<string> arr = name => name.Length <= lenght;

            Console.ReadLine()
                .Split(" ")
                .Where(x => arr(x))
                .ToList()
                .ForEach(Console.WriteLine)
                ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var names=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, string, bool> startWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endWith = (a, b) => a.EndsWith(b);
            Func<string, string, bool> contains = (a, b) => a.Contains(b);
            Func<string, int, bool> length = (a, b) => a.Length==b;

            var input = string.Empty;
            List<string> result = new List<string>(names);
            List<string> filtered = new List<string>();

            while ((input=Console.ReadLine())!="Print")
            {
                var splitedInput = input.Split(";").ToArray();
                var command = splitedInput[0];
                var secondCommand = splitedInput[1];
                var letter = splitedInput[2];
                switch (secondCommand)
                {
                    case "Starts with":
                        filtered = names
                            .Where(i => startWith(i, letter))
                            .ToList();
                        break;
                    case "Ends with":
                        filtered = names
                       .Where(i => endWith(i, letter))
                       .ToList();
                        break;
                    case "Length":
                        filtered = names
                           .Where(i => length(i, int.Parse(letter)))
                           .ToList();
                        break;
                    case "Contains":
                        filtered = names
                           .Where(i => startWith(i, letter))
                           .ToList();
                        break; 
                }
                switch (command)
                {
                    case "Add filter":
                        result.RemoveAll(n => filtered.Contains(n));
                        break;
                    case "Remove filter":
                        result.AddRange(filtered);
                        break;
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ",result));
        }


    }
}

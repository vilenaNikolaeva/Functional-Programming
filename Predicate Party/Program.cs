using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .ToList();
            var input = string.Empty;
            while ((input=Console.ReadLine())!="Party!")
            {
                var splitedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = splitedInput[0];
                var commandExtention = splitedInput.Skip(1).ToArray();

                Predicate<string> predicate=GetPredicate(commandExtention);

                if (command=="Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else if (command=="Double")
                {
                    DoubleGuests(guests, predicate);
                }
            }
            if (guests.Count==0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ",guests)} are going to the party!");
            }
        }

        static void DoubleGuests(List<string> guests, Predicate<string> predicate)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                var currentGuest = guests[i];
                if (predicate(currentGuest))
                {
                    guests.Insert(i + 1, currentGuest);
                    i++;
                }
            }
        }

        static Predicate<string> GetPredicate(string[] predicateArgs)
        {
            var command =predicateArgs[0];
            var extention = predicateArgs[1];
            Predicate<string> predicate=null;
            if (command=="StartsWith")
            {
                predicate = new Predicate<string>((name) =>
                  {
                      return name.StartsWith(extention);
                  });
            }
            else if (command=="EndsWith")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.EndsWith(extention);
                });
            }
            else if (command == "Length")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.Length==int.Parse(extention);
                });
            }
            return predicate;
        }
    }
}

using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());  
            var names = Console.ReadLine()           
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                

            Func<string, int, bool> isValid = (name, num) => name.ToCharArray()
                .Select(ch=>(int)ch).Sum()>=num;

            Func<string[], int, Func<string, int, bool>, string> validName = (arr, num, func) => arr
                .FirstOrDefault(name => func(name, num));

            var result = validName(names, number, isValid);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}

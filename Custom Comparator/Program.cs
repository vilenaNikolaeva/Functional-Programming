using System;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> func = (a, b) =>
                {
                    if (a%2==0 && b%2==1)
                    {
                        return -1;
                    }
                    else if (a%2==1 && b %2==0)
                    {
                        return 1;
                    }
                    else
                    {
                        return a.CompareTo(b);
                    }
                };

            Comparison<int> comp = new Comparison<int>(func);
            var arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(arr, comp);
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}

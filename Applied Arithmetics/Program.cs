using System;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> print = (arr) =>
            Console.WriteLine((string.Join(" ",arr)));
            
            var numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            var command =string.Empty;

            while ((command=Console.ReadLine())!="end")
            {
                if (command=="print")
                {
                    print(numbers);
                }
                else
                {
                    Func<int[], int[]> process = GetProcess(command);
                    numbers = process(numbers);
                }
              
            }
        }

        static Func<int[], int[]> GetProcess(string command)
        {
            Func<int[], int[]> process=null;
            if (command=="add")
            {
                process = new Func<int[], int[]>((arr) =>
                  {
                      for (int i = 0; i < arr.Length; i++)
                      {
                          arr[i]++;
                      }
                      return arr;
                  });
            }
            else if (command=="multiplay")
            {
                process = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]=arr[i]*2;
                    }
                    return arr;
                });
            }
            else if (command == "subtract")
            {
                process = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]--;
                    }
                    return arr;
                });
            }
            return process;
           
        }
    }
}

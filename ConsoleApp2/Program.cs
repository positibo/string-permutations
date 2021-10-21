using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static List<String> permutationResult = new List<String>();

        static void Main(string[] args)
        {
            Console.WriteLine("4.2 String Permutation Challenge");

            Console.WriteLine("Enter a value: ");
            var value = Console.ReadLine();

            ExecutePermute(value, "");

            Console.WriteLine("================================");
            Console.WriteLine("RESULTS: ");
            permutationResult.Sort();
            permutationResult.ForEach(o => Console.WriteLine(o));
        }

        static void ExecutePermute(String value, String result)
        {
            if (value.Length == 0)
            {
                if (!permutationResult.Contains(result))
                {
                    permutationResult.Add(result);
                }
                return;
            }

            for (int x = 0; x < value.Length; x++)
            {
                char ch = value[x];
                ExecutePermute(value.Substring(0, x) + value.Substring(x + 1), result + ch);
            }
        }
    }
}

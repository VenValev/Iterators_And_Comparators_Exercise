using System;
using System.Linq;

namespace _04_Froggy
{
    public class Prog
    {
        static void Main(string[] args)
        {
            var lake = new Lake(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Console.WriteLine(String.Join(", ", lake));
        }
    }
}

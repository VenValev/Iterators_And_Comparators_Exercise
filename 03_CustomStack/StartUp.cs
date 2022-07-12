using System;
using System.Linq;

namespace _03_CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command;
            var stack = new Stack<string>();

            while((command = Console.ReadLine()) != "END")
            {
                var cmndArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmndArg[0] == "Push")
                {
                    stack.Push(cmndArg.Skip(1).Select(e => e.Split(",").First()).ToArray());
                }
                else if (cmndArg[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch(ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
            }

            foreach(var e in stack)
            {
                Console.WriteLine(e);
            }
            foreach (var e in stack)
            {
                Console.WriteLine(e);
            }
        }
    }
}

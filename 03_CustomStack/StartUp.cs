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
                string[] cmndArg = command.Split();

                if (cmndArg[0] == "Push")
                {
                    stack.Push(cmndArg.Skip(1).Select(e => e.Split(',')).First());
                }
                else if (cmndArg[0] == "Pop")
                {

                }
            }
        }
    }
}

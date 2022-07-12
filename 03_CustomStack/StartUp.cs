using System;

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

                }
                else if (cmndArg[0] == "Pop")
                {

                }
            }
        }
    }
}

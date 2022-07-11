using System;
using System.Linq;

namespace _01_ListyIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            ListyIterator<string> listy = null;

            while((command = Console.ReadLine()) != "END")
            {
                var cmndArg = command.Split();

                if (cmndArg[0] == "Create")
                {
                    listy = new ListyIterator<string>(cmndArg.Skip(1).ToArray());
                }
                else if (cmndArg[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (cmndArg[0] == "Print")
                {
                    listy.Print();
                }
                else if (cmndArg[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
            }
        }
    }
}

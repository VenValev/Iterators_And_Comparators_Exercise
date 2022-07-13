using System;
using System.Collections.Generic;

namespace _05_Comparing_Objects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string command;

            while((command = Console.ReadLine()) != "END")
            {
                var cmndArg = command.Split();

                string personName = cmndArg[0];
                int personAge = int.Parse(cmndArg[1]);
                string personTown = cmndArg[2];

                persons.Add(new Person(personName, personAge, personTown));

            }

            var index = int.Parse(Console.ReadLine());
            var equal = 0;
            var notEqual = 0;

            foreach(Person person in persons)
            {

            }
        }
    }
}

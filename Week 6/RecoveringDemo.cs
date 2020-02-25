/*
* Purpose: Based on the the type of class
* (patient, upholsterer, football player)
* the output will display the class's
* "Recover()" status
*
* To compile the program:
* csc RecoveringDemo.cs
*
* To execute the program:
* RecoveringDemo.exe (.exe optional)
*
*/

using System;
using static System.Console;

namespace RecoveringDemo
{
    class RecoveringDemo
    {
        static void Main(string[] args)
        {
            Patient jaime = new Patient("Jaime", "patient");
            Upholsterer fred = new Upholsterer("Fred", "upholsterer");
            FootballPlayer russellWilson = new FootballPlayer("Russell Wilson", "football player");

            WriteLine(jaime.Name + "'s curent status as a " + jaime.Type + ": " + jaime.Recovery());
            WriteLine(fred.Name + "'s curent status as a " + fred.Type + ": " + fred.Recovery());
            WriteLine(russellWilson.Name + "'s curent status as a " + russellWilson.Type + ": " + russellWilson.Recovery());
        }
    }

    class Patient : IRecoverable
    {
        public Patient(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }
        public string Type { get; set; }

        public string Recovery()
        {
            return "Getting Better";
        }
    }

    class Upholsterer : IRecoverable 
    {
        public Upholsterer(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }
        public string Type { get; set; }

        public string Recovery()
        {
            return "Fully Recovered";
        }
    }

    class FootballPlayer : IRecoverable
    {
        public FootballPlayer(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }
        public string Type { get; set; }

        public string Recovery()
        {
            return "In Concussion Protocol";
        }
    }

    public interface IRecoverable
    {
        string Recovery();
    }
}

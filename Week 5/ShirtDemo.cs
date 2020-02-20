/*
* Purpose: Create two shirts from shirt class.
* Display the shirts characteristics.
*
* To compile the program:
* csc ShirDemo.cs
*
* To execute the program:
* ShirDemo.exe (.exe optional)
*
*/

using System;
using static System.Console;

namespace ShirtDemo
{
    class ShirtDemo
    {
        static void Main(string[] args)
        {
            //Create two shirts
            Shirt shirtOne = new Shirt();
            Shirt shirtTwo = new Shirt();
            

            WriteLine("\n{0,0} {1,10} {2,6} {3,6}", "Order #", "Material", "Color", "Size");
            shirtOne.Display();
            shirtTwo.Display();
        }
    }

    class Shirt
    {

        public string Number { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

        //Constructor to be run everytime a shirt is made
        public Shirt()
        {
            AskQuestion();
        }

        //Receive shirt characteristics from user
        public void AskQuestion()
        {
            Write("Enter order number: ");
            Number = ReadLine();
            Write("What material would you like: ");
            Material = ReadLine();
            Write("What color would you like: ");
            Color = ReadLine();
            Write("What size would you like: ");
            Size = ReadLine();
        }

        //Format of shirt display
        public void Display()
        {
            WriteLine("{0,0} {1,14} {2,8} {3,6}", Number, Material, Color, Size);
        }
    }
}

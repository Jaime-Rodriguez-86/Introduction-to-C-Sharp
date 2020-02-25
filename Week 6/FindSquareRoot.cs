/*
* Purpose: Return the square root value
* of a users input
*
* To compile the program:
* csc FindSquareRoot.cs
*
* To execute the program:
* FindSquareRoot.exe (.exe optional)
*
*/

using System;
using static System.Console;

namespace FindSquareRoot
{
    class FindSquareRoot
    {
        static void Main(string[] args)
        {

            SquareRoot sqrt = new SquareRoot();
            try
            {
                Write("Enter a number to find squre root of: ");
                sqrt.UserInput = Convert.ToDouble(ReadLine());
                sqrt.SquareRootValue = Math.Sqrt(sqrt.UserInput);
            }

            //When user input is not a number catch exception
            catch (FormatException e)
            {
                sqrt.SquareRootValue = 0;
                WriteLine(e.Message);
                WriteLine("Input value should be a number");
            }

            //When user input is negative catch exception
            catch (NegativeNumberInput e)
            {
                sqrt.SquareRootValue = 0;
                WriteLine(e.Message);
            }
            WriteLine("\nThe square root of your number is: {0}", sqrt.SquareRootValue);


        }
    }

    //Create ApplicationException
    class NegativeNumberInput : Exception
    {
        //Message to be displayed
        private static string msg = "Input value can not be negative";
        public NegativeNumberInput() : base(msg)
        {
        }
    }

    class SquareRoot
    {
        public double userInput;
        public double SquareRootValue { get; set; }

        public double UserInput
        {
            get
            {
                return userInput;
            }
            set
            {
                //Creating a new instance of our created exception
                if (value < 0)
                {
                    NegativeNumberInput nni = new NegativeNumberInput();
                    throw (nni);
                }
                userInput = value;
            }
        }
    }
}

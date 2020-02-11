/*
* Purpose: Receiver user inputs and store
* them in an array.
* Depending on users choice array will be 
* displayed in increasing or decreasing or 
* display specific array index.
*
* To compile the program:
* csc ArrayDemo.cs
*
* To execute the program:
* ArrayDemo.exe (.exe optional)
*
*/

using System;
using static System.Console;

namespace ArrayDemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
			//Create an array
			int[] jerseyNumbers = new int[10];
			int userInput;

			//User inputs to be stored in array
			WriteLine("**Enter your top 10 favorite jersey numbers from favorite to least favorite**\n");
			for (int i = 0; i < jerseyNumbers.Length; i++)
			{
				Write("Enter a jersey number {0} ", i + 1);
				jerseyNumbers[i] = Convert.ToInt32(ReadLine());
			}
			WriteLine("\n");

			//Prompt user to enter desired outcome
			//Continual do loop in order to continue running program until terminated
			do
			{
				Console.WriteLine("---------------------------");
				Console.WriteLine("ENTER YOUR DESIRED OUTOCOME");
				Console.WriteLine("---------------------------");
				Console.WriteLine("For rank 1 to 10  **ENTER 1**");
				Console.WriteLine("For rank 10 to 1  **ENTER 2**");
				Console.WriteLine("For specific rank **ENTER 3**");
				Console.WriteLine("To quit program   **ENTER 000**");

				userInput = Convert.ToInt32(Console.ReadLine());

				//Correct user input check
				if (userInput != 000 && (userInput < 1 || userInput > 3))
				{
					Console.WriteLine("*** INVALID INPUT *** Enter 1,2,3 or 000 to terminate");
				}

				//Use cases to determine user input outcome
				switch (userInput)
				{
					//For loop to display index 0 to 9
					case 1:
						Console.WriteLine("\n");
						Console.WriteLine("Jersey numbers ranked 1 - 10");
						for (int i = 0; i < jerseyNumbers.Length; i++)
						{
							Console.Write(jerseyNumbers[i] + " ");
						}
						Console.WriteLine("\n\n");
						break;
					//For loop to display index 9 to 0
					case 2:
						Console.WriteLine("\n");
						Console.WriteLine("Jersey numbers ranked 10 - 1");
						for (int i = 9; i >= 0; i--)
						{
							Console.Write(jerseyNumbers[i] + " ");
						}
						Console.WriteLine("\n\n");
						break;
					//If else to determine specific index
					case 3:
						Console.WriteLine(" ______");
						Console.WriteLine("Enter a rank from 1-10");
						//Allow a second prompt to determine index
						int extraInput = Convert.ToInt32(Console.ReadLine());
						if (extraInput >= 1 && extraInput <= 10)
							//Subtract one from userinput in order to return proper index
							//User friendly to eliminate people not using zero indexing
							Console.WriteLine("\nJersey number {0} has a rank of {1}\n\n", jerseyNumbers[extraInput - 1], extraInput);
						else
							Console.WriteLine("\n*** INVALID INPUT ***\n\n");
						break;
				}
			}
			//Terminate program
			while (userInput != 000);
			WriteLine("\nGoodbye");

		}
  }
}

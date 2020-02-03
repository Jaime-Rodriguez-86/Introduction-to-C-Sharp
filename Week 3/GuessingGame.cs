/*
* Purpose: Have a user take a guess at
* the number that will be randomly generated.
* Console will let user know if they were too
* high, low, or a match
*
* To compile the program:
* csc GuessingGame.cs
*
* To execute the program:
* GuessingGame.exe (.exe optional)
*
*/

using System;
using static System.Console;

namespace GuessingGame
{
					
	public class Program
	{
		public static void Main()
		{
			string guessString;
			int guess;
		
			WriteLine("WELCOME TO THE GUESSING GAME!");
			Write("Enter a number from 1 to 10: ");
			guessString = ReadLine();
			guess = Convert.ToInt32(guessString);
		
			//Generate random number from 1-10
			Random ranNumberGenerator = new Random();
     			int randomNumber;
     			randomNumber = ranNumberGenerator.Next(1, 11);
		
			//If number matches
			if(guess == randomNumber)
				WriteLine("Great guess! Your number is a match!");
			else
				//If number is too high
				if(guess > randomNumber)
					WriteLine("Sorry the winning number is {0}. Your guess of {1} is too high.", randomNumber, guess);
			else
				//If number is too low
				if(guess < randomNumber)
					WriteLine("Sorry the winning number is {0}. Your guess of {1} is too low.", randomNumber, guess);	
		}
	}
}

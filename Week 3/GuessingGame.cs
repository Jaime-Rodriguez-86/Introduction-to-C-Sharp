using System;
					
public class Program
{
	public static void Main()
	{
		string guessString;
		int guess;
		
		Console.WriteLine("WELCOME TO THE GUESSING GAME!");
		Console.Write("Enter a number from 1 to 10: ");
		guessString = Console.ReadLine();
		guess = Convert.ToInt32(guessString);
		
		Random ranNumberGenerator = new Random();
     	int randomNumber;
     	randomNumber = ranNumberGenerator.Next(1, 11);
		
		if(guess == randomNumber)
			Console.WriteLine("Great guess! Your number is a match!");
		else
			if(guess > randomNumber)
				Console.WriteLine("Sorry the winning number is {0}. Your guess of {1} is too high.", randomNumber, guess);
		else
			if(guess < randomNumber)
				Console.WriteLine("Sorry the winning number is {0}. Your guess of {1} is too low.", randomNumber, guess);
		
		
	}
}

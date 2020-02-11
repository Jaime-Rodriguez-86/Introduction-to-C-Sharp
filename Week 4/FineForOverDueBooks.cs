/*
* Purpose: Calcuate users book fines
* dependent on the number of books and 
* the number of days past due
*
* To compile the program:
* csc FineForOverdueBooks.cs
*
* To execute the program:
* FineForOverdueBooks.exe (.exe optional)
*
*/

using System;
using static System.Console;

namespace FineForOverdueBooks
{
    class FineForOverdueBooks
    {
        static void Main(string[] args)
        {
			WriteLine("***Library Fine System***\n");
			
			Write("Enter number of books past due: ");
			int numberOfBooks = Convert.ToInt32(ReadLine());
			Write("\nEnter number of days past due: ");
			int numberOfDays = Convert.ToInt32(ReadLine());

			double myFines;
			//Invoke created method using users inputs
			myFines = CalcFines(numberOfDays, numberOfBooks);

			//Outcome for fines due
			WriteLine("\n-------------Fine Statement-------------");
			WriteLine("You had {0} book(s) for {0} extra day(s).", numberOfBooks, numberOfDays);
			WriteLine("The fee is {0}.", myFines.ToString("C"));
		}

		private static double CalcFines(double days, double books)
		{
			double cost = .10;
			double extraCost = .30;

			//First tier of fines for 7 days or less
			if (days <= 7)
			{
				double fine = (cost * books) * days;
				return fine;
			}
			//Second tier of fines for more than 7 days
			else
			{
				double extraFine = ((cost * books) * days) + ((extraCost * books) * (days - 7));
				return extraFine;
			}
		}
	}
}

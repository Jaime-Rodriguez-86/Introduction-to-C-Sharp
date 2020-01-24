/*
 * Purpose: Calculate an customers
 * moving estimate based off companies rates
 *
 * To compile the program:
 * csc MalcomMovers.cs
 *
 * To execute the program:
 * MalcomMovers.exe (.exe optional)
 *
 */

using System;
using static System.Console;
using System.Globalization;

namespace Assignment_1_3
{
    internal class MalcomMovers
    {
        public static void Main(string[] args)
        {
            // Rates for Malcom Movers, also utilizing currency format
            double baseRate = 200;
            string baseString = baseRate.ToString("C");
            double hourRate = 150;
            string hourString = hourRate.ToString("C");
            double mileRate = 2;
            string mileString = mileRate.ToString("C");

            // Creating userinput variables
            string customerHoursAsString;
            double customerHours;
            string customerMilesAsString;
            double customerMiles;

            // User input for number of hours
            Write("Enter your jobs estimated hours: ");
            customerHoursAsString = ReadLine();
            customerHours = Convert.ToDouble(customerHoursAsString);
            // User input for distance in miles
            Write("Enter the miles of your job: ");
            customerMilesAsString = ReadLine();
            customerMiles = Convert.ToDouble(customerMilesAsString);
            
            // Hourly, Mileage, and Subtotal for customer job
            double hourlyTotal = customerHours * hourRate;
            string hourlyString = hourlyTotal.ToString("C");
            double mileageTotal = customerMiles * mileRate;
            string mileageString = mileageTotal.ToString("C");
            double subTotal = baseRate + hourlyTotal + mileageTotal;
            string subString = subTotal.ToString("C");
            
            // Review of customers job
            WriteLine("Your job should take {0} hours and covers a distance of {1} mile(s).",customerHours,customerMiles);
            
            WriteLine("");
            
            // Price estimate for customer
            WriteLine("Your estimate is as follows: ");
            WriteLine("Base Rate: {0}", baseString);
            WriteLine("Hourly Total: {0} x {1} = {2}", hourString, customerHours, hourlyString );
            WriteLine("Mileage Total: {0} x {1} = {2}", mileString, customerMiles, mileageString);
            WriteLine("Subtotal = {0}", subString);
        }
    }
}

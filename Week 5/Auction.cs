/*
* Purpose: Receive users bid. Check whether
* bid is above minimum bid amount and meets
* format.
*
* To compile the program:
* csc Autcion.cs
*
* To execute the program:
* Auction.exe (.exe optional)
*/

using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace Auction
{
    class Auction
    {
        static void Main(string[] args)
        {
            int min = 10;

            Write("Place your first bid: ");
            int bidOne = Convert.ToInt32(ReadLine());
            UserBid(bidOne, min);

            Write("Place your second bid: ");
            double bidTwo = Convert.ToDouble(ReadLine());
            UserBid(bidTwo, min);

            Write("Place third bid: ");
            string bidThree = ReadLine();
            UserBid(bidThree, min);
        }


        private static void UserBid(int bid, int min)
        {

            if (bid < min)
            {
                WriteLine("Your bid of {0} does not meet the minimum bid of {1}.", bid.ToString("C"), min.ToString("C"));
               
            }
            else if(bid >= min)
            {
                WriteLine("Thank you. Your bid of {0} is accepted.", bid.ToString("C"));
            }
        }

        private static void UserBid(double bid, int min)
        {
            if (bid < min)
            {
                Write("Your bid of {0} does not meet the minimum bid of {1}.", bid.ToString("C"), min.ToString("C"));
            }
            else if (bid >= min)
            {
                WriteLine("Thank you. Your bid of {0} is accepted.", bid.ToString("C"));
            }
        }

        private static void UserBid(string bid, int min)
        {
            string dollars = "dollars";
            char moneySign = '$';
            double number;

            //If user input starts with $ proceed to check if number value is high enough
            if(bid.StartsWith(moneySign) == true && double.TryParse(bid.Substring(1), out number))
            {
                if(number < min)
                {
                    WriteLine("Your bid of {0} does not meet the minimum bid of {1}.", number.ToString("C"), min.ToString("C"));
                }
                 else if (number >= min)
                {
                    WriteLine("Thank you. Your bid of {0} is accepted.", bid);
                }

            }
            //If user input ends with dollars proceed to check if number value is high enough
            else if (bid.EndsWith(dollars) == true && double.TryParse(bid.Substring(0, bid.IndexOf(dollars)), out number))
            {
                if (number < min)
                {
                    WriteLine("Your bid of {0} does not meet the minimum bid of {1}.", number.ToString("C"), min.ToString("C"));
                }
                else if (number >= min)
                {
                    WriteLine("Thank you. Your bid of {0} is accepted.", number.ToString("C"));
                }

            }
            //If format of starting with $ or ending with dollars is not met
            else
            {
                WriteLine("Incorrect format. Format should follow $XX or XX dollars");
            }
        }   
    }
}

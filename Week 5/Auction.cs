/*
*Write, compile, and test a console application named Auction 
*that allows a user to enter an amount bid on an online auction item.  
*Include three overloaded methods that accept an int, double, or string bid.  
*Each method should display the bid and indicate whether it is over the minimum 
*acceptable bid of $10.  If the bid is a string, accept it only if one of the 
*follow is true: it is numeric and preceded with a dollar sign, or it is numeric 
*and followed by the word dollars.  Otherwise, display a message that indicates the format was incorrect.
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

            while (bid < min)
            {
                Write("Minimum bid not placed. Bid again: ");
                bid = Convert.ToInt32(ReadLine());
            }
            if(bid >= min)
            {
                WriteLine("Thank you. Your bid of {0} is accepted.", bid.ToString("C"));
            }
        }

        private static void UserBid(double bid, int min)
        {
            while (bid < min)
            {
                Write("Minimum bid not placed. Bid again: ");
                bid = Convert.ToDouble(ReadLine());
            }
            if (bid >= min)
            {
                WriteLine("Thank you. Your bid of {0} is accepted.", bid.ToString("C"));
            }
        }

        private static void UserBid(string bid, int min)
        {
            string dollars = "dollars";
            char moneySign = '$';
            

            if(bid.StartsWith(moneySign) == true)
            {
                WriteLine("Thank you. Your bid of {0} is accepted.", bid);

            }
            else if(bid.EndsWith(dollars) == true)
            {
                WriteLine("Thank you. Your bid of {0} is accepted.", bid);
            }
            else
            {
                WriteLine("Incorrect format. Follow example $XX or XX dollars");
                Write("Bid again: ");
                bid = Convert.ToString(ReadLine());
            }

        }

        

    }
}

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

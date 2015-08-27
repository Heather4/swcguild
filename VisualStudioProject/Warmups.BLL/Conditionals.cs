using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Conditionals
    {
        /* We have two children, a and b, and the parameters aSmile and 
           bSmile indicate if each is smiling. We are in trouble if they 
           are both smiling or if neither of them is smiling. Return true 
           if we are in trouble. 
        */
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
                return true;

            if (!aSmile && !bSmile)
                return true;

            return false;
        }

        //SleepingIn- The parameter weekday is true if it is a weekday, and the parament vacation is true if we are on vacation
        //We sleep in if it is not a weekday or we're on vacation.  Return true if we sleep in
        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (isWeekday == false || isVacation == true)
            {
                return true;
            }
            return false;
        }

        //SumDouble- Given 2 int values, return their sum.  However, if the 2 values are the same, return double their sum
        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return (2*(a + b));
            }
            return a + b;
        }

        //Diff21- Given an int n, return the absolute value of the difference between n and 21, except double the 
        //absolute value of the difference if n is over 21.
        public int Diff21(int n)
        {
            if (n > 21)
            {
                return (2*(n-21));
            }
            return 21 - n;
        }
    }
}

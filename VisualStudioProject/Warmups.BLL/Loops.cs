using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Loops
    {
        /* Given a string and a non-negative int n, return a 
           larger string that is n copies of the original string. 
        */
        public string StringTimes(string str, int n)
        {
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += str;
            }

            return result;
        }

        //FrontTimes- Given a string and a non-negative int n, the front of the string is the first 3 chars (or whatever is there is less than length 3).
        //return n copies of the front
        public string FrontTimes(string str, int n)
        {
            string x = "";
            str = str.Substring(0, 3);
            for (int i = 0; i < n; i++)
            {
                x += str;
                //Console.WriteLine("x = {0} and str = {1}", x, str);
                //Ringo's comment to show how the loop adds on the string
            }
            return x;
        }

        //CountXX- Count the number of "xx" in the given string.  Overlapping is allowed, so "xxx" contains 2.
        public int CountXX(string str)
        {
            //Randall says to think of i as positional with string loops
            //char prev = ' ';   error, unassigned value never used
            int counter = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == 'x' && str[i] == 'x')
                {
                    counter ++;
                }
            }
            return counter;
        }
    }
}


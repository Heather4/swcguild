using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Strings
    {
        // Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!". 
        public string SayHi(string name)
        {
            return string.Format("Hello {0}!", name);
        }

        //Given two strings, a & b, return result in the order abba
        public string Abba(string a, string b)
        {
            return string.Format("{0}{1}{1}{0}", a, b);
        }

        //Given tag and word strings, create the HTML string with tags around the word, e.g. "<i>Yay</i>
        public string MakeTags(string tag, string content)
        {
            return string.Format("<{0}>{1}</{0}>", tag, content);
        }

        //Given an "out" string length 4, such as "<<>>", and a word, return a new string where the work is in the middle of the out string, e.g."<<word>>"
        public string InsertWord(string container, string word)
        {
            return string.Format("{0}{1}{2}", container.Substring(0, 2), word, container.Substring(2, 2));
        }

        //Given a string return a new string made of 3 copies of the last 2 chars of the original string. String will be at least 2
        public string MultipleEndings(string str)
        {
            return string.Format("{0}{0}{0}", str.Substring(str.Length - 2, 2));
        }

        //FirstHalf- Given a string of even length, return the first half.  So "WooHoo" yields "Woo"
        public string FirstHalf(string str)
        {
            int halfindex = str.Length/2;
            return string.Format("{0}", str.Substring(0, halfindex));
        }

        //TrimOne- Given a string, return a version without the first and last car, so "Hello" yields "ell".
        //the string will be at least 2.
        public string TrimOne(string str)
        {
            return string.Format("{0}", str.Substring(1, str.Length - 2));
        }

        //LongInMiddle- Given 2 strings, a and b, return a string of the form short+long+short, with the shorter
        //string on the outside and the longer string on the inside.  The strings will not be the same length
        //but they may be empty
        public string LongInMiddle(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return string.Format("{0}{1}{0}", a, b);
            }
            else
            {
                return string.Format("{1}{0}{1}", a, b);
            }
        }

        //RotateLeft2- Given a string, return a "rotated left 2" version where the first 2
        //chars are moved to the end.  The string length will be at least 2
        public string Rotateleft2(string str)
        {
            if (str.Length > 2)
            {
                return string.Format("{0}", str.Substring(2) + str.Substring(0, 2));
            }
            else
            {
                return str;
            }
        }

        //RotateRight2- Given a string, return a "rotated right 2" version
        //were the last 2 cars are moved to the start
        public string Rotateright2(string str)
        {
            if (str.Length > 2)
            {
                return string.Format("{0}", str.Substring(str.Length - 2, 2) + str.Substring(0, str.Length - 2));
            }
            else
            {
                return str;
            }
        }

        //TakeOne- Given a string, return a string length 1 from its front, unless front is false
        //in which case return a string length 1 from it's back.
        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront == true)
            {
                return string.Format("{0}", str.Substring(0, 1));
            }
            else
            {
                return string.Format("{0}", str.Substring(str.Length - 1, 1));
            }
        }

        //MiddleTwo- Given a string of even length, return a string made of the middle two chars, so the 
        //string "string" yields "ri".  Length will be at least 2
        public string MiddleTwo(string str)
        {
            int halfIndex = str.Length/2;
            return string.Format("{0}", str.Substring(halfIndex - 1, 2));
        }

        //EndsWithLy- Given a string, return true if it ends in "ly"
        public bool EndsWithLy(string str)
        {
            if (str.Length > 2 && str.Substring(str.Length - 2, 2) == "ly")
            {
                return true;
            }
            return false;
        }

        //FrontAndBack- Given a string and an int n, return a string made of the first and last n chars from 
        //the string.  The string length will be at least n.
        public string FrontAndBack(string str, int n)
        {
            return string.Format("{0}", str.Substring(0, n) + str.Substring(str.Length - n, n));
        }

        //TakeTwoFromPosition- Given a string and an index, return a string length 2 starting at the given index. 
        //If the index is too bigg or too small to defien a string length 2, use the first 2 chars.
        //String length will be at least 2
        public string TakeTwoFromPosition(string str, int n)
        {
            if (n >= str.Length - 1)
            {
                return string.Format("{0}", str.Substring(0, 2));
            }
            else
            {
                return string.Format("{0}", str.Substring(n, 2));
            }
        }

        //HasBad- Given a string, return true if "bad" appears starting at index 0 or 1 in the string, such as with "badxxx"
        //or"xbadxx" but not "xxbadxx". String may be any length, including 0.
        public bool HasBad(string str)
        {
            if (str.Substring(0, 3) == "bad" || str.Substring(1, 3) == "bad")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //AtFirst- Given a string, return a string length 2 made of it's first 2 chars
        //if the string length is less than 2, use '@" for the missing chars
        public string AtFirst(string str)
        {
            if (str.Length < 2)
            {
                return string.Format("{0}", (str.Substring(0, 1) + "@"));
            }
            else
            {
                return string.Format("{0}", str.Substring(0, 2));
            }
        }

        //Last Char- Given 2 strings, a & b, return a new string made of the first char of a and the last char of b
        //if either string is length 0 use '@' for it's missing char
        public string LastChars(string a, string b)
        {
            if (a.Length == 0)
            {
                return string.Format("{0}", "@" + b.Substring(0, 1));
            }
            else if (b.Length == 0)
            {
                return string.Format("{0}", a.Substring(0, 1) + "@");
            }
            else
            {
                return string.Format("{0}", a.Substring(0, 1) + b.Substring(b.Length - 1, 1));
            }

        }

        //ConCat- Given two strings, append them together & return the result.  If concatenation creates a double-char, omit
        //one of the chars, so "abc" & "cat" yields "abcat"
        public string ConCat(string a, string b)
        {
            if (a.Length == 0 || b.Length == 0)
            {
                return string.Format("{0}", a + b);
            }
            else if (a.Substring(a.Length - 1, 1) == b.Substring(0, 1))
            {
                return string.Format("{0}", a.Substring(0, a.Length - 1) + b);
            }
            else
            {
                return string.Format("{0}", a + b);
            }
        }

        //SwapLast- given a string of any length, return a new string where the last 2 chars, if present, are swapped.
        public string SwapLast(string str)
        {
            return str.Substring(0, str.Length - 2) + str.Substring(str.Length - 1, 1) +
                   str.Substring(str.Length - 2, 1);
        }

        //FrontAgain- Given a string, return true if the first 2 chars in the staring also appear at the end of the string.
        public bool FrontAgain(string str)
        {
            if (str.Substring(0, 2) == str.Substring(str.Length - 2, 2))
            {
                return true;
            }
            return false;
        }

        //MinCat- Given 2 strings, append them together & return the result. However, if the strings are different lengths, omit chars
        //from the longer string so it is the same length as the shorter string.
        public string MinCat(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return string.Format("{0}", a.Substring(a.Length - b.Length, b.Length) + b);
            }
            else
            {
                return string.Format("{0}", a + b.Substring(b.Length - a.Length, a.Length));
            }
        }

        //TweakFront- Given a string, return a version w/o the first 2 chars. Keep the first char if it's an 'a' & keep the second if it's
        //a 'b'
        public string TweakFront(string str)
        {
            if (str.Substring(0, 1) == "a" && str.Substring(1, 1) == "b")
            {
                return string.Format("{0}", str);
            }
            if (str.Substring(0,1) == "a")
            {
                return string.Format("{0}", str.Remove(1, 1));
            }
            if (str.Substring(1, 1) == "b")
            {
                return string.Format("{0}", str.Remove(1, 1));
            }
            else
            {
                return string.Format("{0}", str.Remove(0, 2));
            }
        }

        //StripX- Given a string, if the first or last chars are 'x', return the string w/o those 'x's, otherwise return the string unchanged.
        public string StripX(string str)
        {
            if (str.Substring(0, 1) == "x" && str.Substring(str.Length - 1, 1) == "x")
            {
                return string.Format("{0}", str.Substring(1, str.Length - 2));
            }
            else if (str.Substring(0,1) == "x")
            {
                return string.Format("{0}", str.Remove(0, 1));
            }
            else if (str.Substring(str.Length - 1) == "x")
            {
                return string.Format("{0}", str.Remove(str.Length - 1, 1));
            }
            else
            {
                return string.Format("{0}", str);
            }
        }


    }
}

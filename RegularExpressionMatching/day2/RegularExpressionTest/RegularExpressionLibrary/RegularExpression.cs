using System;
using System.Diagnostics;

namespace RegularExpressionLibrary
{
    public class RegularExpression
    {
        public RegularExpression()
        {
        }

        public bool isMatch(string text, string pattern)
        {
            if (isContainSpecialChar(pattern))
            {
                foreach (char element in text)
                {
                    Debug.WriteLine("element : {0}", element);
                }

                return false;
            }
            else
            {
                return text.Equals(pattern);
            }
        }

        private static bool isContainSpecialChar(string pattern)
        {
            return pattern.Contains(".") || pattern.Contains("*");
        }
    }
}
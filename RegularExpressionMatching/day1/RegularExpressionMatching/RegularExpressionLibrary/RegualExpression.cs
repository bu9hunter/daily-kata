using System;

namespace RegularExpressionLibrary
{
    public class RegualExpression
    {
        public RegualExpression()
        {
        }

        public bool isMatch(string inputString, string pattern)
        {
            return pattern.Equals(inputString);
        }
    }
}
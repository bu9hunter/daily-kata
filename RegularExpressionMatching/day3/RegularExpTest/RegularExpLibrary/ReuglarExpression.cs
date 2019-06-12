using System;

namespace RegularExpLibrary
{
    public class RegularExpression
    {
        public RegularExpression()
        {
        }

        public bool isMatch(string text, string pattern)
        {
            int idx = 0;
            string temp;

            if (hasWildCardChar(pattern))
            {
                foreach (char element in pattern)
                {
                    
                    if (element.Equals("."))
                    {
                        
                    }
                    else if (element.Equals("*"))
                    {

                    }
                    else
                    {

                    }

                    idx++;
                }
                return false;
            }
            else
            {
                return text.Equals(pattern);
            }
        }

        private static bool hasWildCardChar(string pattern)
        {
            return pattern.Contains(".") || pattern.Contains("*");
        }
    }
}
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
            bool result = false; ;

            char[] patternArray = pattern.ToCharArray();

            if (hasSpecialChar(pattern))
            {
                foreach (char ch in text)
                {
                    for (; idx < text.Length; idx++)
                    {

                        if (patternArray[idx] == '.')
                        {
                            result = true;
                        }
                        else if (patternArray[idx] =='*')
                        {
                            result = false;
                        }
                        else
                        {
                            result = patternArray[idx] == ch;
                        }

                        idx++;
                        break;
                    }
                }
                
                return result;
            }
            else
            {
                return text.Equals(pattern);
            }
        }

        private static bool hasSpecialChar(string pattern)
        {
            return pattern.Contains(".") || pattern.Contains("*");
        }
    }
}
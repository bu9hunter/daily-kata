using System;
using System.Collections.Generic;
using System.Text;

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
            List<char> CompareText = new List<char>();

            if (hasSpecialChar(pattern))
            {
                foreach (char ch in text)
                {
                    for (; idx < text.Length; idx++)
                    {

                        if (patternArray[idx] == '.')
                        {
                            // result = true;
                            CompareText.Add(ch);
                        }
                        else if (patternArray[idx] =='*')
                        {
                            //result = patternArray[idx - 1] == ch;
                            //CompareText.Add()
                        }
                        else
                        {
                            //result = patternArray[idx] == ch;
                            CompareText.Add(ch);
                        }

                        idx++;
                        break;
                    }
                }

                string temp = CompareText.ToString();

                return CompareText.ToString().Equals(text);
                
                //return result;
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
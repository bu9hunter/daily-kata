using System;

namespace WordWrap
{
    public class WordWrapper
    {
        public WordWrapper()
        {
        }

        public string Wrap(string inputString, int length)
        {
            string resultString = "";
            if (length > inputString.Length)
            {
                return inputString;
            }

            if (inputString.Substring(0, length).Contains(" "))
            { 
                resultString = inputString.Replace(" ", "--");
            }
            return resultString;
        }
    }
}
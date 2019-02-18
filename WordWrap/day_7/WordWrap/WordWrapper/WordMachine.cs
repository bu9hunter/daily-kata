using System;

namespace WordWrapper
{
    public class WordMachine
    {
        public string wrap(string text, int length)
        {
            string tempString = "";
            int spacePosition;
            int totalLength = text.Length;

            tempString = text.Substring(0, length);
            spacePosition = tempString.LastIndexOf(" ");

            if (spacePosition == -1)
            {
                return text;
            }
            else
            {
                if (spacePosition < length)
                {
                }
            }

            return text;
        }
    }
}
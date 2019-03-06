using System;

namespace WordWrap
{
    public class WordWrapper
    {
        public WordWrapper()
        {
        }

        public string Wrap(string inputText, int limit)
        {
            string wrappedString = "";
            string remainString = "";
            int lastSpacePosition = 0;
            int length = 0;
            int line = 0;

            if (limit > inputText.Length)
            {
                return inputText;
            }

            remainString = inputText;

            while (remainString.Length > limit)
            {
                lastSpacePosition = remainString.Substring(0, limit).LastIndexOf(" ");

                if (lastSpacePosition == -1)
                {
                    wrappedString += remainString.Substring(0, limit);
                    length = wrappedString.Length;
                    wrappedString += "--";
                }
                else if (lastSpacePosition == limit - 1)
                {
                    wrappedString += remainString.Substring(0, lastSpacePosition);
                    length = wrappedString.Length;
                    wrappedString += "--";
                }

                remainString = inputText.Substring(length).Trim();
            }
            
            return wrappedString + remainString;
        }
    }
}
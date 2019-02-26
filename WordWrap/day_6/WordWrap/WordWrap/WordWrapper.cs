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
            string resultString = "";
            string wrappedString = "";
            string remainString = "";
            int lastSpacePosition = 0;
            int length = 0;

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
                else if (lastSpacePosition < limit)
                {
                    wrappedString += remainString.Substring(0, lastSpacePosition);
                    length = wrappedString.Length;
                    wrappedString += "--";
                }

                if (lastSpacePosition == -1)
                {
                    remainString = remainString.Substring(limit, remainString.Length - limit);
                }
                else
                {
                    remainString = remainString.Substring(lastSpacePosition + 1, remainString.Length - length - 1);
                }
            }
            
            return wrappedString + remainString;
        }
    }
}
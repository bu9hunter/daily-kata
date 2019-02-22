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
            string temp = "";
            int lastSpacePosition = 0;
            int startPosition = 0;

            if (limit > inputText.Length)
            {
                return inputText;
            }

            while (limit < inputText.Length)
            {
                lastSpacePosition = inputText.Substring(startPosition, limit).LastIndexOf(" ");

                if (lastSpacePosition < limit)
                {
                    wrappedString += inputText.Substring(startPosition, lastSpacePosition);
                    wrappedString += "--";
                    wrappedString += inputText.Substring(lastSpacePosition + 1, inputText.Length - lastSpacePosition - 1);
                    startPosition += limit;
                    limit += limit;
                }
            }
            
            return wrappedString;
        }
    }
}
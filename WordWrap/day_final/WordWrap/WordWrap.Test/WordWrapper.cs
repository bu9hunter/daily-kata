using System;

namespace WordWrap.Test
{
    public class WordWrapper
    {
        internal string wrap(string inputText, int limit)
        {
            int lastSpacePosition;
            string wrappedText = "";
            string remainText = "";

            if (inputText.Length < limit)
            {
                return inputText;
            }

            remainText = inputText;

            while (remainText.Length > limit)
            {
                lastSpacePosition = remainText.Substring(0, limit).LastIndexOf(' ');

                //if (lastSpacePosition == -1)
                //{
                //    return inputText;
                //}

                if (lastSpacePosition < limit)
                {
                    wrappedText += remainText.Substring(0, lastSpacePosition);
                    wrappedText += "--";
                    remainText = remainText.Substring(lastSpacePosition + 1);
                }
            }

            return wrappedText + remainText;
        }
    }
}
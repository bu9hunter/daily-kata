using System;

namespace WordWrap.Test
{
    public class WordWrapper
    {
        public WordWrapper()
        {
        }

        internal string wrap(string inputText, int limit)
        {
            int lastSpacePosition;
            int firstSpacePosition;
            int wordSize;
            string wrappedText = "";
            string remainText = "";

            if (inputText.Length <= limit)
            {
                return inputText;
            }

            remainText = inputText;

            while (remainText.Length > limit)
            {
                lastSpacePosition = remainText.Substring(0, limit).LastIndexOf(' ');
                firstSpacePosition = remainText.Substring(limit - 1).IndexOf(' ');

                if (lastSpacePosition == -1)
                {
                    lastSpacePosition = 0;
                }

                if (firstSpacePosition == -1)
                {
                    firstSpacePosition = remainText.Length;
                } else
                {
                    firstSpacePosition = limit - 1 + firstSpacePosition;
                }

                wordSize = firstSpacePosition - lastSpacePosition;

                if (wordSize > limit || lastSpacePosition == 0)
                {
                    wrappedText += remainText.Substring(0, limit);
                    wrappedText += "--";
                    remainText = remainText.Substring(limit).TrimStart();
                    continue;
                }

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
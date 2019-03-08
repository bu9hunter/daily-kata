using System;

namespace WordWrap
{
    public class WordWrapper
    {
        public WordWrapper()
        {
        }

        public string wrap(string inputText, int limit)
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
                firstSpacePosition = remainText.Substring(limit + 1).IndexOf(' ');

                if (lastSpacePosition == -1)
                {
                    lastSpacePosition = 0;
                }

                if (firstSpacePosition == -1)
                {
                    firstSpacePosition = remainText.Substring(limit).Length;
                }

                wordSize = firstSpacePosition + (limit - lastSpacePosition);

                if (wordSize > limit)
                {
                    wrappedText += remainText.Substring(0, limit);
                    wrappedText += "--";
                    remainText = remainText.Substring(limit).Trim();
                    continue;
                }

                if (lastSpacePosition < limit)
                {
                    wrappedText += remainText.Substring(0, lastSpacePosition);
                    wrappedText += "--";
                    remainText = remainText.Substring(lastSpacePosition + 1).Trim();
                }
            }

            return wrappedText + remainText;
        }
    }
}
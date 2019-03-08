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
            int wordSize;

            if (inputText.Length <= limit)
            {
                return inputText;
            }
            else
            {
                
                return inputText.Substring(0, limit) + "--" + Wrap(inputText.Substring(limit), limit);
            }
        }
    }
}
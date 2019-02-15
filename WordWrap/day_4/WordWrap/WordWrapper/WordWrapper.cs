using System;

namespace WordWrap
{
    internal class WordWrapper
    {
        public WordWrapper()
        {
        }

        internal string wrap(string text, int length)
        {
            string[] words = text.Split(' ');
            string wrappedString = "";
            int i = 0;

            while (true)
            {
                if (words.Length <= i)
                    break;

                if (words[i].Length < length)
                {
                    wrappedString += words[i++];
                } else
                {
                    wrappedString += "--" + words[i++];
                }
            }

            return wrappedString;
        }
    }
}
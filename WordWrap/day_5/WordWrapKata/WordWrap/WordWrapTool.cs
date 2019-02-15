using System;

namespace WordWrap
{
    public class WordWrapTool
    {
        public WordWrapTool()
        {
        }

        public string Wrap(string text, int length)
        {
            string[] words = text.Split(' ');
            string wrappedText = "";
            int totalLength = 0;

            foreach (var word in words)
            {
                totalLength += word.Length + 1;
                if (totalLength < length)
                {
                    wrappedText += word + ' ';
                }
                else
                {
                    wrappedText += "--" + word + ' ';
                    totalLength -= length;
                }
            }

            return wrappedText;
        }
    }
}
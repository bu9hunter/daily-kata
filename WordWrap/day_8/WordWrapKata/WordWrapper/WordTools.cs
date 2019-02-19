using System;

namespace WordWrapper
{
    public class WordTools
    {
        public WordTools()
        {
        }

        public string wrap(string inputText, int length)
        {
            string temp = "";
            int spacePosition;

            if (inputText.Length < length)
            {
                return inputText;
            } else
            {
                if (inputText.Substring(0, length).LastIndexOf(" ") == -1)
                {
                    return inputText;
                } else if (inputText.Substring(length, 1) != "")
                {
                    return inputText;
                }
            }
               

            //spacePosition = inputText.IndexOf(" ");

            //if (spacePosition < length)
            //{
            //    temp += inputText.Substring(0, spacePosition);
            //    temp += "--";
            //    temp += inputText.Substring(spacePosition + 1, inputText.Length - spacePosition - 1);
            //}

            return temp;
        }
    }
}
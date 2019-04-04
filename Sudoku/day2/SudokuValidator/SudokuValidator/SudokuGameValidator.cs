using System;

namespace SudokuValidator
{
    public class SudokuGameValidator
    {
        public bool ValidateMatrix3by3(int[,] matrix)
        {
            int answerSum = 6;
            int totalSum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    totalSum += matrix[i, j];
                }

                if (totalSum != answerSum)
                    return false;
                else
                    totalSum = 0;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    totalSum += matrix[j, i];
                }

                if (totalSum != answerSum)
                    return false;
                else
                    totalSum = 0;
            }

            return true;
        }

        public bool ValidateMatrix9by9(int[,] matrix)
        {
            int answerSum = 45;
            int totalSum = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    totalSum += matrix[i, j];
                }

                if (totalSum != answerSum)
                    return false;
                else
                    totalSum = 0;
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    totalSum += matrix[j, i];
                }

                if (totalSum != answerSum)
                    return false;
                else
                    totalSum = 0;
            }

            return true;
        }
    }
}
using System;
using System.Collections;

namespace SudokuSolver
{
    public class SudokuGameSolver
    {
        public int[,] solve(int[,] matrix, int size)
        {
            bool[] checkNumber = new bool[size];
            int blank = 0;
            int blankValue = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int cell = matrix[i, j];
                    if (cell != 0)
                    {
                        checkNumber[cell - 1] = true;
                    }
                }

                for (int j = 0; j < size; j++)
                {
                    if (checkNumber[j] == false)
                    {
                        blank++;
                        blankValue = j + 1;
                    }
                }

                if (blank == 1)
                {
                    for (int j = 0; j < size; j++)
                    {
                        int cell = matrix[i, j];
                        if (cell == 0)
                        {
                            matrix[i, j] = blankValue;
                        }
                    }
                }
            }
            return null;
        }
    }
}
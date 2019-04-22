using System;
using System.Collections;

namespace SudokuSolver
{
    public class SudokuGameSolver
    {
        public SudokuGameSolver()
        {
        }

        public int[,] solve(ref int[,] matrix, int size)
        {
            bool bCompleted = false;

            while (!bCompleted)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        bool[] checkNumber = new bool[size];

                        if (isBlank(matrix, i, j))
                        {
                            checkRow(matrix, size, i, ref checkNumber);
                            checkColumn(matrix, size, j, ref checkNumber);
                            fillOutBlank(matrix, size, i, j, checkNumber);
                        }
                    }
                }

                int blankCount = 0;

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (isBlank(matrix, i, j))
                        {
                            blankCount++;
                        }
                    }
                }

                if (blankCount == 0)
                    bCompleted = true;
            }

            return matrix;
        }

        private static bool isBlank(int[,] matrix, int i, int j)
        {
            return matrix[i, j] == 0;
        }

        private static void fillOutBlank(int[,] matrix, int size, int i, int j, bool[] checkNumber)
        {
            int blankCount = 0;
            for (int checkIdx = 0; checkIdx < size; checkIdx++)
            {
                if (checkNumber[checkIdx] == false)
                {
                    blankCount++;
                }
            }

            if (blankCount > 1)
                return;

            for (int checkIdx = 0; checkIdx < size; checkIdx++)
            {
                if (checkNumber[checkIdx] == false)
                {
                    matrix[i, j] = checkIdx + 1;
                }
            }
        }

        private static void checkColumn(int[,] matrix, int size, int j, ref bool[] checkNumber)
        {
            for (int chkColumn = 0; chkColumn < size; chkColumn++)
            {
                int value = matrix[chkColumn, j];
                if (value != 0)
                {
                    checkNumber[value - 1] = true;
                }
            }
        }

        private static void checkRow(int[,] matrix, int size, int i, ref bool[] checkNumber)
        {
            for (int chkRow = 0; chkRow < size; chkRow++)
            {
                int value = matrix[i, chkRow];
                if (value != 0)
                {
                    checkNumber[value - 1] = true;
                }
            }
        }
    }
}
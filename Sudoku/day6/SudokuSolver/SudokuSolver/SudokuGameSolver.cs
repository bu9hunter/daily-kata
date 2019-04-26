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
            while (!isCompleted(matrix, size))
            {
                fillOutBlankByCheckingRowColumn(matrix, size);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        bool[] checkNumber = new bool[size];

                        if (isBlank(matrix, i, j))
                        {
                            checkRow(matrix, size, i, ref checkNumber);
                            checkColumn(matrix, size, j, ref checkNumber);
                            checkMatrix3by3(matrix, size, i, j, ref checkNumber);
                            fillOutBlank(matrix, size, i, j, checkNumber);
                        }
                    }
                }
            }

            return matrix;
        }

        private static void fillOutBlankByCheckingRowColumn(int[,] matrix, int size)
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
        }

        private static bool isCompleted(int[,] matrix, int size)
        {
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
                return true;

            return false;
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

        private static void checkMatrix3by3(int[,] matrix, int size, int i, int j, ref bool[] checkNumber)
        {
            int startRow = 0;
            int endRow = 0;
            int startColumn = 0;
            int endColumn = 0;

            if (i < 3)
            {
                startRow = 0;
                endRow = 3;
            }
            else if (i < 6)
            {
                startRow = 3;
                endRow = 6;
            }
            else if (i < 9)
            {
                startRow = 6;
                endRow = 9;
            }

            if (j < 3)
            {
                startColumn = 0;
                endColumn = 3;
            }
            else if (j < 6)
            {
                startColumn = 3;
                endColumn = 6;
            }
            else if (j < 9)
            {
                startColumn = 6;
                endColumn = 9;
            }

            for (int startRowIdx = startRow; startRowIdx < endRow; startRowIdx++)
            {
                for (int startColumnIdx = startColumn; startColumnIdx < endColumn; startColumnIdx++)
                {
                    int value = matrix[startRowIdx, startColumnIdx];
                    if (value != 0)
                    {
                        checkNumber[value - 1] = true;
                    }
                }
            }
        }
    }
}
using System;
using System.Collections;
using System.Linq;

namespace SudokuSolver
{
    public class SudokuGameSolver
    {
        int[,] orignalMatrix = new int[9, 9];
        int loopCount = 0;

        public SudokuGameSolver()
        {
        }

        public int[,] solve(ref int[,] matrix, int size)
        {
            int solveCount = 0;

            while (!isCompleted(matrix, size))
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

                            if (isMatrix9by9(size))
                            {
                                checkMatrix3by3(matrix, size, i, j, ref checkNumber);
                            }

                            if (loopCount > 1)
                            {
                                loopCount = 0;
                                fillOutBlankWithExpectedValue(matrix, size, i, j, checkNumber);
                            }
                            else
                            {
                                fillOutBlank(matrix, size, i, j, checkNumber);
                            }
                        }
                    }
                }

                //if (loopCount > 1 && isDuplicated(matrix, size)) break;
                
                Array.Copy(matrix, orignalMatrix, matrix.Length);
                loopCount++;

                solveCount++;
            }

            System.Diagnostics.Debug.WriteLine("Solve Count = {0}", solveCount);

            return matrix;
        }

        private static bool isMatrix9by9(int size)
        {
            return size == 9;
        }

        private void fillOutBlankWithExpectedValue(int[,] matrix, int size, int i, int j, bool[] checkNumber)
        {
            for (int checkIdx = 0; checkIdx < size; checkIdx++)
            {
                if (checkNumber[checkIdx] == false)
                {
                    matrix[i, j] = checkIdx + 1;
                    checkNumber[checkIdx] = true;
                }
            }
        }

        private bool isDuplicated(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (orignalMatrix[i , j] != matrix[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
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
            return CalculateBlank(matrix, size) == 0;
        }

        private static int CalculateBlank(int[,] matrix, int size)
        {
            int blankCount = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (isBlank(matrix, i, j))
                    {
                        System.Diagnostics.Debug.WriteLine("matrix[{0},{1}] is Blank", i, j);
                        blankCount++;
                    }
                }
            }

            return blankCount;
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

            SetRowColumnPosition(i, j, ref startRow, ref endRow, ref startColumn, ref endColumn);

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

        private static void SetRowColumnPosition(int i, int j, ref int startRow, ref int endRow, ref int startColumn, ref int endColumn)
        {
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
        }
    }
}
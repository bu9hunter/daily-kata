using System;
using System.Collections;

namespace SodukuSolver
{
    public class SudokuSolver
    {
        public SudokuSolver()
        {
        }

        public int[,] Solve(int[,] matrix, int size)
        {
            bool[] foundNumber = new bool[size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        if (i != 0 || i != (size - 1))
                        {

                        }
                    }
                }
            }

            return null;
        }
    }
}
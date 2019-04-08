using System;

namespace SudokuValidator
{
    public class SudokuGameValidator
    {
        public bool ValidateSolution(int[,] matrix, int matrixSize)
        {
            int totalSum = 0;

            bool result = true;

            for (int i = matrixSize; i > 0; i--)
            {
                totalSum += i;
            }

            for (int i = 0; i < matrixSize; i++)
            {
                int rowSum = 0;
                int columnSum = 0;

                for (int j = 0; j < matrixSize; j++)
                {
                    rowSum += matrix[i, j];
                    columnSum += matrix[j, i];
                }

                if (rowSum != totalSum || columnSum != totalSum)
                {
                    result = false;
                    break;                    
                }
            }

            return result;
        }
    }
}
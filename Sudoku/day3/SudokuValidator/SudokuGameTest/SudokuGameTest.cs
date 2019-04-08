using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuValidator;

namespace SudokuGameTest
{
    [TestClass]
    public class SudokuGameTest
    {
        [TestMethod]
        public void MakeInstance()
        {
            SudokuGameValidator sudokuGameValidator = new SudokuGameValidator();
        }

        [TestMethod]
        public void ValidateMatrixFor3x3()
        {
            int[,] matrix3by3 = new int[,]
            {
                { 1, 2, 3 },
                { 3, 1 ,2 },
                { 2, 3, 1 }
            };

            int size = matrix3by3.GetLength(1);

            SudokuGameValidator sudokuGameValidator = new SudokuGameValidator();

            Assert.AreEqual(true, sudokuGameValidator.ValidateSolution(matrix: matrix3by3, matrixSize: size));
        }

        [TestMethod]
        public void ValidateWrongMatrixFor3x3()
        {
            int[,] matrix3by3 = new int[,]
            {
                { 1, 2, 3 },
                { 3, 1 ,0 },
                { 0, 3, 1 }
            };

            int size = 3;

            SudokuGameValidator sudokuGameValidator = new SudokuGameValidator();

            Assert.AreEqual(false, sudokuGameValidator.ValidateSolution(matrix: matrix3by3, matrixSize: size));
        }

        [TestMethod]
        public void ValidateMatrixFor9x9()
        {
            int[,] matrix9by9 = new int[,]
            {
                { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
            };

            int size = 9;

            SudokuGameValidator sudokuGameValidator = new SudokuGameValidator();

            Assert.AreEqual(true, sudokuGameValidator.ValidateSolution(matrix: matrix9by9, matrixSize: size));
        }

        [TestMethod]
        public void ValidateWrongMatrixFor9x9()
        {
            int[,] matrix9by9 = new int[,]
            {
                {5, 3, 4, 6, 7, 8, 9, 1, 2},
                {6, 7, 2, 1, 9, 0, 3, 4, 8},
                {1, 0, 0, 3, 4, 2, 5, 6, 0},
                {8, 5, 9, 7, 6, 1, 0, 2, 0},
                {4, 2, 6, 8, 5, 3, 7, 9, 1},
                {7, 1, 3, 9, 2, 4, 8, 5, 6},
                {9, 0, 1, 5, 3, 7, 2, 1, 4},
                {2, 8, 7, 4, 1, 9, 6, 3, 5},
                {3, 0, 0, 4, 8, 1, 1, 7, 9}
            };

            int size = 9;

            SudokuGameValidator sudokuGameValidator = new SudokuGameValidator();

            Assert.AreEqual(false, sudokuGameValidator.ValidateSolution(matrix: matrix9by9, matrixSize: size));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuValidator;

namespace SudokuValidatorTest
{
    [TestClass]
    public class SudokuGameTest
    {
        [TestMethod]
        public void MakeInstnace()
        {
            SudokuGameValidator sudokuGameValidator = new SudokuGameValidator();
        }

        [TestMethod]
        public void ValidateMatrix3by3()
        {
            int[,] matrix3by3 = new int[,]
            {
                {1, 2, 3},
                {2, 3, 1},
                {3, 1, 2}
            };

            SudokuGameValidator validator = new SudokuGameValidator();

            Assert.AreEqual(true, validator.ValidateMatrix3by3(matrix : matrix3by3));
        }

        [TestMethod]
        public void ValidateMatrix9by9()
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

            SudokuGameValidator validator = new SudokuGameValidator();

            Assert.AreEqual(true, validator.ValidateMatrix9by9(matrix: matrix9by9));
        }
    }
}

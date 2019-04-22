using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver;

namespace SudokuSolverTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MakeInstance()
        {
            SudokuGameSolver sudokuGameSolver = new SudokuGameSolver();
        }

        [TestMethod]
        public void ChangeArray()
        {
            int[] testArray = new int[] { 1, 2, 3 };

            ChangeArray(ref testArray);

            Assert.AreEqual(2, testArray[0]);
        }

        private void ChangeArray(ref int[] testArray)
        {
            testArray[0] = 2;
        }

        [TestMethod]
        public void SolveMatrix3by3_1st()
        {
            int[,] matrix3by3 = new int[,]
            {
                { 3, 2, 0 },
                { 0, 0, 3 },
                { 1, 3, 0 }
            };

            int[,] answerForMatrix3by3 = new int[,]
            {
                { 3, 2, 1 },
                { 2, 1, 3 },
                { 1, 3, 2 }
            };

            SudokuGameSolver sgs = new SudokuGameSolver();

            CollectionAssert.AreEqual(answerForMatrix3by3, sgs.solve(matrix: ref matrix3by3, size: matrix3by3.GetLength(1)));
        }

        [TestMethod]
        public void SolveMatrix3by3_2nd()
        {
            int[,] matrix3by3 = new int[,]
            {
                { 0, 0, 3 },
                { 2, 0, 0 },
                { 0, 0, 0 }
            };

            int[,] answerForMatrix3by3 = new int[,]
            {
                { 1, 2, 3 },
                { 2, 3, 1 },
                { 3, 1, 2 }
            };

            SudokuGameSolver sgs = new SudokuGameSolver();

            CollectionAssert.AreEqual(answerForMatrix3by3, sgs.solve(matrix: ref matrix3by3, size: matrix3by3.GetLength(1)));
        }

        [TestMethod]
        public void SolveMatrix3by3_3rd()
        {
            int[,] matrix3by3 = new int[,]
            {
                { 1, 0, 0 },
                { 0, 0, 0 },
                { 0, 3, 0 }
            };

            int[,] answerForMatrix3by3 = new int[,]
            {
                { 1, 2, 3 },
                { 3, 1, 2 },
                { 2, 3, 1 }
            };

            SudokuGameSolver sgs = new SudokuGameSolver();

            CollectionAssert.AreEqual(answerForMatrix3by3, sgs.solve(matrix: ref matrix3by3, size: matrix3by3.GetLength(1)));
        }

        [TestMethod]
        public void SolveMatrix9by9_1st()
        {
            int[,] matrix9by9 = new int[,]
            {
                {5,3,0,0,7,0,0,0,0},
                {6,0,0,1,9,5,0,0,0},
                {0,9,8,0,0,0,0,6,0},
                {8,0,0,0,6,0,0,0,3},
                {4,0,0,8,0,3,0,0,1},
                {7,0,0,0,2,0,0,0,6},
                {0,6,0,0,0,0,2,8,0},
                {0,0,0,4,1,9,0,0,5},
                {0,0,0,0,8,0,0,7,9}
            };

            int[,] answerForMatrix9by9 = new int[,]
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

            SudokuGameSolver sgs = new SudokuGameSolver();

            CollectionAssert.AreEqual(answerForMatrix9by9, sgs.solve(matrix: ref matrix9by9, size: matrix9by9.GetLength(1)));
        }
    }
}

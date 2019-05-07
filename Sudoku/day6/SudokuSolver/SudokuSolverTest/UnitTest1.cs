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
                {6, 7, 2, 1, 9, 5, 3, 4, 8},
                {1, 9, 8, 3, 4, 2, 5, 6, 7},
                {8, 5, 9, 7, 6, 1, 4, 2, 3},
                {4, 2, 6, 8, 5, 3, 7, 9, 1},
                {7, 1, 3, 9, 2, 4, 8, 5, 6},
                {9, 6, 1, 5, 3, 7, 2, 8, 4},
                {2, 8, 7, 4, 1, 9, 6, 3, 5},
                {3, 4, 5, 2, 8, 6, 1, 7, 9}
            };

            SudokuGameSolver sgs = new SudokuGameSolver();

            CollectionAssert.AreEqual(answerForMatrix9by9, sgs.solve(matrix: ref matrix9by9, size: matrix9by9.GetLength(1)));
        }

        [TestMethod]
        public void SolveMatrix9by9_Q1()
        {
            int[,] matrix9by9 = new int[,]
            {
                {9, 4, 1,  0, 0, 2,  0, 0, 0},
                {0, 0, 0,  0, 0, 0,  0, 5, 0},
                {0, 0, 0,  7, 0, 0,  1, 3, 0},

                {8, 0, 0,  0, 0, 3,  0, 6, 0},
                {3, 6, 2,  1, 0, 7,  5, 9, 4},
                {0, 9, 0,  5, 0, 0,  0, 0, 8},

                {0, 5, 7,  0, 0, 1,  0, 0, 0},
                {0, 3, 0,  0, 0, 0,  0, 0, 0},
                {0, 0, 0,  2, 0, 0,  6, 7, 1}
            };

            int[,] answerForMatrix9by9 = new int[,]
            {
                {9, 4, 1,  3, 5, 2,  7, 8, 6},
                {6, 7, 3,  8, 1, 9,  4, 5, 2},
                {5, 2, 8,  7, 6, 4,  1, 3, 9},

                {8, 1, 5,  9, 4, 3,  2, 6, 7},
                {3, 6, 2,  1, 8, 7,  5, 9, 4},
                {7, 9, 4,  5, 2, 6,  3, 1, 8},

                {2, 5, 7,  6, 9, 1,  8, 4, 3},
                {1, 3, 6,  4, 7, 8,  9, 2, 5},
                {4, 8, 9,  2, 3, 5,  6, 7, 1}
            };

            SudokuGameSolver sgs = new SudokuGameSolver();

            CollectionAssert.AreEqual(answerForMatrix9by9, sgs.solve(matrix: ref matrix9by9, size: matrix9by9.GetLength(1)));
        }

        [TestMethod]
        public void SolveMatrix9by9_Q2()
        {
            int[,] matrix9by9 = new int[,]
            {
                {4, 3, 5,  0, 6, 1,  0, 7, 0},
                {7, 6, 0,  0, 0, 0,  3, 0, 0},
                {0, 0, 0,  0, 0, 0,  0, 4, 0},

                {0, 0, 0,  8, 0, 0,  0, 0, 3},
                {3, 0, 0,  5, 7, 9,  0, 0, 4},
                {8, 0, 0,  0, 0, 4,  0, 0, 0},

                {0, 8, 0,  0, 0, 0,  0, 0, 0},
                {0, 0, 1,  0, 0, 0,  0, 9, 7},
                {0, 9, 0,  7, 4, 0,  5, 6, 1}
            };

            int[,] answerForMatrix9by9 = new int[,]
            {
                {4, 3, 5,  9, 6, 1,  2, 7, 8},
                {7, 6, 9,  4, 8, 2,  3, 1, 5},
                {1, 2, 8,  3, 5, 7,  9, 4, 6},

                {9, 5, 4,  8, 1, 6,  7, 2, 3},
                {3, 1, 2,  5, 7, 9,  6, 8, 4},
                {8, 7, 6,  2, 3, 4,  1, 5, 9},

                {6, 8, 7,  1, 9, 5,  4, 3, 2},
                {5, 4, 1,  6, 2, 3,  8, 9, 7},
                {2, 9, 3,  7, 4, 8,  5, 6, 1}
            };

            SudokuGameSolver sgs = new SudokuGameSolver();

            CollectionAssert.AreEqual(answerForMatrix9by9, sgs.solve(matrix: ref matrix9by9, size: matrix9by9.GetLength(1)));
        }
        //[TestMethod]
        //public void SolveMatrix9by9_Q3()
        //{
        //    int[,] matrix9by9 = new int[,]
        //    {
        //        {7, 0, 0,  0, 0, 9,  3, 4, 8},
        //        {0, 0, 0,  0, 4, 0,  0, 1, 0},
        //        {0, 0, 0,  5, 0, 0,  0, 0, 0},

        //        {9, 1, 0,  4, 0, 0,  0, 7, 0},
        //        {6, 0, 0,  9, 0, 3,  0, 0, 1},
        //        {0, 3, 0,  0, 0, 1,  0, 2, 9},

        //        {0, 0, 0,  0, 0, 5,  0, 0, 0},
        //        {0, 8, 0,  0, 1, 0,  0, 0, 0},
        //        {4, 9, 3,  8, 0, 0,  0, 0, 2}
        //    };

        //    int[,] answerForMatrix9by9 = new int[,]
        //    {
        //        {7, 5, 6,  1, 2, 9,  3, 4, 8},
        //        {3, 2, 9,  6, 4, 8,  7, 1, 5},
        //        {8, 4, 1,  5, 3, 7,  2, 9, 6},

        //        {9, 1, 8,  4, 6, 2,  5, 7, 3},
        //        {6, 7, 2,  9, 5, 3,  4, 8, 1},
        //        {5, 3, 4,  7, 8, 1,  6, 2, 9},

        //        {1, 6, 7,  2, 9, 5,  8, 3, 4},
        //        {2, 8, 5,  3, 1, 4,  9, 6, 7},
        //        {4, 9, 3,  8, 7, 6,  1, 5, 2}
        //    };

        //    SudokuGameSolver sgs = new SudokuGameSolver();

        //    CollectionAssert.AreEqual(answerForMatrix9by9, sgs.solve(matrix: ref matrix9by9, size: matrix9by9.GetLength(1)));
        //}


        //[TestMethod]
        //public void SolveMatrix9by9_Q4()
        //{
        //    int[,] matrix9by9 = new int[,]
        //    {
        //        {0, 0, 3,  9, 0, 2,  0, 5, 0},
        //        {0, 0, 0,  0, 6, 0,  3, 0, 0},
        //        {0, 0, 0,  3, 0, 0,  0, 0, 4},

        //        {0, 6, 7,  0, 0, 0,  5, 9, 0},
        //        {5, 0, 4,  0, 9, 0,  1, 0, 3},
        //        {0, 8, 9,  0, 0, 0,  7, 4, 0},

        //        {4, 0, 0,  0, 0, 7,  0, 0, 0},
        //        {0, 0, 5,  0, 2, 0,  0, 0, 0},
        //        {0, 3, 0,  6, 0, 1,  4, 0, 0}
        //    };

        //    int[,] answerForMatrix9by9 = new int[,]
        //    {
        //        {4, 3, 5,  9, 6, 1,  2, 7, 8},
        //        {7, 6, 9,  4, 8, 2,  3, 1, 5},
        //        {1, 2, 8,  3, 5, 7,  9, 4, 6},

        //        {9, 5, 4,  8, 1, 6,  7, 2, 3},
        //        {3, 1, 2,  5, 7, 9,  6, 8, 4},
        //        {8, 7, 6,  2, 3, 4,  1, 5, 9},

        //        {6, 8, 7,  1, 9, 5,  4, 3, 2},
        //        {5, 4, 1,  6, 2, 3,  8, 9, 7},
        //        {2, 9, 3,  7, 4, 8,  5, 6, 1}
        //    };

        //    SudokuGameSolver sgs = new SudokuGameSolver();

        //    CollectionAssert.AreEqual(answerForMatrix9by9, sgs.solve(matrix: ref matrix9by9, size: matrix9by9.GetLength(1)));
        //}
    }
}

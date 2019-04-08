using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SodukuSolver;

namespace SulokuSolverTest
{
    [TestClass]
    public class UnitTest1
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

        [TestMethod]
        public void MakeInstance()
        {
            SudokuSolver sudokuSolver = new SudokuSolver();
        }

        [TestMethod]
        public void matrix3by3Solver()
        {
            SudokuSolver sudokuSolver = new SudokuSolver();

            CollectionAssert.AreEqual(answerForMatrix3by3, sudokuSolver.Solve(matrix : matrix3by3, size : matrix3by3.GetLength(1)));
        }
    }
}

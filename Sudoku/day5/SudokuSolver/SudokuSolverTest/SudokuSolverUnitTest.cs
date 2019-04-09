using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver;

namespace SudokuSolverTest
{
    [TestClass]
    public class SudokuSolverUnitTest
    {
        [TestMethod]
        public void MakeInstance()
        {
            SudokuGameSolver sudokuSolver = new SudokuGameSolver();
        }

        [TestMethod]
        public void SolveMatrix3by3()
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

            SudokuGameSolver sudokuGameSolver = new SudokuGameSolver();

            CollectionAssert.AreEqual(answerForMatrix3by3, sudokuGameSolver.solve(matrix : matrix3by3, size : matrix3by3.GetLength(1)));
        }
    }
}

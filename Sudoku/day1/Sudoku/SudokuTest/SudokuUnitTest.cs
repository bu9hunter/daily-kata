using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace SudokuTest
{
    [TestClass]
    public class SudokuUnitTest
    {
        [TestMethod]
        public void MakeInstance()
        {
            SudokuValidator validator = new SudokuValidator(); 
        }

        [TestMethod]
        public void ValidateMatrix3x3()
        {
        }
    }
}

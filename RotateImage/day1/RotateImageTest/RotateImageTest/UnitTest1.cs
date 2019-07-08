using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotateImageSolution;

namespace RotateImageTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MakeInstance()
        {
            RotateImage rotateImage = new RotateImage();
        }

        [TestMethod]
        public void Rotate1RowBy90degrees()
        {
            int[,] inputMatrix = new int[,]
            {
                { 1, 2, 3 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            int[,] rotateMatrix = new int[,]
            {
                { 0, 0, 1 },
                { 0, 0, 2 },
                { 0, 0, 3 }
            };

            RotateImage rotateImage = new RotateImage();

            rotateImage.Rotate(ref inputMatrix);

            CollectionAssert.AreEqual(rotateMatrix, inputMatrix);
        }
    }
}

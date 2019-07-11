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

        [TestMethod]
        public void Rotate2RowBy90degrees()
        {
            int[,] inputMatrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 0, 0, 0 }
            };

            int[,] rotateMatrix = new int[,]
            {
                { 0, 4, 1 },
                { 0, 5, 2 },
                { 0, 6, 3 }
            };

            RotateImage rotateImage = new RotateImage();

            rotateImage.Rotate(ref inputMatrix);

            CollectionAssert.AreEqual(rotateMatrix, inputMatrix);
        }

        [TestMethod]
        public void Rotate3RowBy90degrees()
        {
            int[,] inputMatrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] rotateMatrix = new int[,]
            {
                { 7, 4, 1 },
                { 8, 5, 2 },
                { 9, 6, 3 }
            };

            RotateImage rotateImage = new RotateImage();

            rotateImage.Rotate(ref inputMatrix);

            CollectionAssert.AreEqual(rotateMatrix, inputMatrix);
        }
    }
}

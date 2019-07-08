using System;

namespace RotateImageSolution
{
    public class RotateImage
    {
        public RotateImage()
        {
        }

        public void Rotate(ref int[,] inputMatrix)
        {
            // Set Contents
            inputMatrix[2, 2] = inputMatrix[0, 2];
            inputMatrix[1, 2] = inputMatrix[0, 1];
            inputMatrix[0, 2] = inputMatrix[0, 0];

            // Clear Contents
            inputMatrix[0, 0] = 0;
            inputMatrix[0, 1] = 0;
            inputMatrix[0, 2] = 0;
        }
    }
}
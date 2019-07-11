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
            int[] temp = new int[3];
            bool clearOne = false;
            bool clearTwo = false;

            if (inputMatrix[1, 0] == 0) clearOne = true;
            if (inputMatrix[2, 0] == 0) clearTwo = true;

            // Backup
            temp[2] = inputMatrix[2, 2];
            temp[1] = inputMatrix[1, 2];
            temp[0] = inputMatrix[0, 2];

            // Set Column #3
            inputMatrix[2, 2] = temp[0];
            inputMatrix[1, 2] = inputMatrix[0, 1];
            inputMatrix[0, 2] = inputMatrix[0, 0];

            // Set Column #2
            inputMatrix[2, 1] = temp[1];
            inputMatrix[1, 1] = inputMatrix[1, 1];
            inputMatrix[0, 1] = inputMatrix[1, 0];

            // Set Column #1
            inputMatrix[2, 0] = temp[2];
            inputMatrix[1, 0] = inputMatrix[2, 1];
            inputMatrix[0, 0] = inputMatrix[2, 0];

            // Clear Contents
            if (clearOne) inputMatrix[0, 0] = 0;
            if (clearTwo) inputMatrix[1, 0] = 0;

            //inputMatrix[0, 2] = 0;
        }
    }
}
using System;

namespace BowlingGame
{
    public class Game
    {
        int m_totalScore = 0;
        int[,] frames = new int[11, 2];
        int frameCount = 0;
        int rollCount = 0;

        public void Roll(int pins)
        {
            frames[frameCount, rollCount++] = pins;
            if (rollCount == 2)
            {
                frameCount++;
                rollCount = 0;
            }
        }

        public int Score()
        {
            for (int i = 0; i < 10; i++)
            {
                int currentScore = 0;

                for (int j = 0; j < 2; j++)
                {
                    currentScore += frames[i, j];
                    if (j == 0 && currentScore == 10)
                    {
                        currentScore += frames[i + 1, 0];
                        currentScore += frames[i + 1, 1];
                        break;
                    }
                    else if (j == 1 && currentScore == 10)
                    {
                        currentScore += frames[i + 1, 0];
                    }
                }

                m_totalScore += currentScore;
            }

            return m_totalScore;
        }
    }
}
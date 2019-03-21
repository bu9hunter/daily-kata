using System;

namespace BowlingGame
{
    public class Game
    {
        int[] score = new int[22];
        int rollCount = 0;

        public int Score()
        {
            int totalScore = 0;
            int frameScore = 0;

            for (int i = 0; i < 22; i = i + 2)
            {
                frameScore += score[i];
                frameScore += score[i + 1];

                if (frameScore == 10)
                {
                    frameScore += score[i + 2];
                }

                totalScore += frameScore;
            }

            return totalScore;
        }

        public void Roll(int pins)
        {
            score[rollCount++] = pins;
        }
    }
}
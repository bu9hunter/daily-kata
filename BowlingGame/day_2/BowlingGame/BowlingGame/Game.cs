using System;

namespace BowlingGame
{
    public class Game
    {
        int m_TotalScore;


        public Game()
        {
        }

        public int Score()
        {
            return m_TotalScore;
        }

        public void Roll(int knockedDownPins)
        {
            m_TotalScore += knockedDownPins;
        }
    }
}
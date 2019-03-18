using System;

namespace BowlingGame
{
    public class Game
    {
        int m_pins;

        public int score()
        {
            return m_pins;
        }

        public void roll(int pins)
        {
            m_pins += pins;
        }
    }
}
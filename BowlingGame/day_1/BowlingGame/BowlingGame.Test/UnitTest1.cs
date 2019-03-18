using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Game인스턴스만들기()
        {
            Game game = new Game();
        }

        [TestMethod]
        public void 점수_확인하기()
        {
            int score;

            Game game = new Game();

            score = game.score();

            Assert.AreEqual(0, score);
        }

        [TestMethod]
        public void 첫번째시도_핀1개_치고_점수_확인하기()
        {
            int expectedScore = 1;
            int actualScore;
            
            Game game = new Game();

            game.roll(1);
            actualScore = game.score();

            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void 첫번째시도_핀1개_두번째시도_핀3개_치고_점수_확인하기()
        {
            int expectedScore = 4;
            int actualScore;

            Game game = new Game();

            // frame #1
            game.roll(1);
            game.roll(3);
            actualScore = game.score();

            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void 두번째_프레임까지_진행한_점수_확인하기()
        {
            int expectedScore = 10;
            int actualScore;

            Game game = new Game();

            // frame #1
            game.roll(1);
            game.roll(3);
            // frame #2
            game.roll(5);
            game.roll(1);
            actualScore = game.score();

            Assert.AreEqual(expectedScore, actualScore);
        }
    }
}

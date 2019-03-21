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
        public void 아무것도_치지않았을때_점수확인하기()
        {
            int score;

            Game game = new Game();

            score = game.Score();

            Assert.AreEqual(0, score);
        }

        [TestMethod]
        public void 한번던져_핀1개_넘어뜨리고_점수확인하기()
        {
            int score;
            int knockedDownPins = 1;

            Game game = new Game();

            game.Roll(knockedDownPins);
            score = game.Score();

            Assert.AreEqual(1, score);
        }

        [TestMethod]
        public void 한프레임_진행후_점수확인하기()
        {
            int score;

            Game game = new Game();

            game.Roll(1);
            game.Roll(4);
            score = game.Score();

            Assert.AreEqual(5, score);
        }

        [TestMethod]
        public void 두프레임_진행후_점수확인하기()
        {
            int score;

            Game game = new Game();

            // frame #1
            game.Roll(1);
            game.Roll(4);

            // frame #2
            game.Roll(4);
            game.Roll(5);

            score = game.Score();

            Assert.AreEqual(14, score);
        }

        [TestMethod]
        public void 스페어_처리후_점수확인하기()
        {
            int score;

            Game game = new Game();

            // frame #1
            game.Roll(1);
            game.Roll(9);

            // frame #2
            game.Roll(2);
            game.Roll(5);

            score = game.Score();

            Assert.AreEqual(19, score);
        }
    }
}

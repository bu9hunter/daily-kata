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
        public void 핀0개_치고_점수_확인하기()
        {
            int score;

            Game game = new Game();

            game.Roll(0);
            score = game.Score();

            Assert.AreEqual(0, score);
        }

        [TestMethod]
        public void 핀5개_치고_점수_확인하기()
        {
            int score;

            Game game = new Game();

            game.Roll(5);
            score = game.Score();

            Assert.AreEqual(5, score);
        }

        [TestMethod]
        public void 두번치고_점수_확인하기()
        {
            int score;

            Game game = new Game();

            game.Roll(1);
            game.Roll(4);
            score = game.Score();

            Assert.AreEqual(5, score);
        }

        [TestMethod]
        public void 두번째_프레임까지_스페어없는경우_점수_확인하기()
        {
            int score;

            Game game = new Game();

            // #1 Frame
            game.Roll(1);
            game.Roll(4);

            // #2 Frame
            game.Roll(4);
            game.Roll(5);
            score = game.Score();

            Assert.AreEqual(14, score);
        }

        [TestMethod]
        public void 첫번째_프레임에_스페어처리한경우_점수_확인하기()
        {
            int score;

            Game game = new Game();

            // #1 Frame
            game.Roll(1);
            game.Roll(9);

            // #2 Frame
            game.Roll(4);
            game.Roll(5);
            score = game.Score();

            Assert.AreEqual(23, score);
        }
    }
}

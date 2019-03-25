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
        public void 핀쓰러뜨리고_점수확인하기()
        {
            int score;

            Game game = new Game();

            game.Roll(3);
            score = game.Score();

            Assert.AreEqual(3, score);
        }

        [TestMethod]
        public void 한프레임_치고_점수확인하기()
        {
            int score;

            Game game = new Game();

            game.Roll(3);
            game.Roll(5);

            score = game.Score();

            Assert.AreEqual(8, score);
        }

        [TestMethod]
        public void 두번던져_첫프레임_스페어처리하고_점수확인하기()
        {
            int score;

            Game game = new Game();

            // #1 frame
            game.Roll(3);
            game.Roll(7);

            // #2 frame
            game.Roll(3);
            game.Roll(5);

            score = game.Score();

            Assert.AreEqual(21, score);
        }

        [TestMethod]
        public void 세번던져_첫프레임_스페어처리하고_점수확인하기()
        {
            int score;

            Game game = new Game();

            // #1 frame
            game.Roll(3);
            game.Roll(7);

            // #2 frame
            game.Roll(3);
            game.Roll(5);

            // #3 frame
            game.Roll(2);
            game.Roll(3);

            score = game.Score();

            Assert.AreEqual(26, score);
        }

        [TestMethod]
        public void 세번던져_첫프레임_스트라이크처리하고_점수확인하기()
        {
            int score;

            Game game = new Game();

            // #1 frame
            game.Roll(10);
            game.Roll(0);

            // #2 frame
            game.Roll(3);
            game.Roll(5);

            // #3 frame
            game.Roll(2);
            game.Roll(3);

            score = game.Score();

            Assert.AreEqual(31, score);
        }

        [TestMethod]
        public void 테스트_1게임치고_점수확인하기()
        {
            int score;

            Game game = new Game();

            // #1 frame
            game.Roll(1);
            game.Roll(4);

            // #2 frame
            game.Roll(4);
            game.Roll(5);

            // #3 frame
            game.Roll(6);
            game.Roll(4);

            // #4 frame
            game.Roll(5);
            game.Roll(5);

            // #5 frame
            game.Roll(10);
            game.Roll(0);

            // #6 frame
            game.Roll(0);
            game.Roll(1);

            // #7 frame
            game.Roll(7);
            game.Roll(3);

            // #8 frame
            game.Roll(6);
            game.Roll(4);

            // #9 frame
            game.Roll(10);
            game.Roll(0);

            // #10 frame
            game.Roll(2);
            game.Roll(8);

            // #11 bonus frame
            game.Roll(6);

            score = game.Score();

            Assert.AreEqual(133, score);
        }
    }
}

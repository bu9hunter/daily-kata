using System;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest
{
    [TestClass]
    public class UnitTest1
    {
        Game g;

        [TestInitialize]
        public void Setup()
        {
            g = new Game();
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.Roll(pins: pins);
        }

        [TestMethod]
        public void testGutterGame()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void testAllOnes()
        {
            RollMany(20, 1);
            
            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void testOneSpare()
        {
            rollSpare();
            g.Roll(3);

            RollMany(17, 0);

            Assert.AreEqual(16, g.Score());
        }

        [TestMethod]
        public void testOneStrike()
        {
            rollStrike();
            g.Roll(3);
            g.Roll(4);

            RollMany(16, 0);

            Assert.AreEqual(24, g.Score());
        }

        [TestMethod]
        public void testPerfactGame()
        {
            RollMany(12, 10);

            Assert.AreEqual(300, g.Score());
        }

        private void rollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

        private void rollStrike()
        {
            g.Roll(10);
        }
    }
}

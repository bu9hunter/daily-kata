using System;
using MaxAreaOfIsland;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaxAreaOfIslandTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void makeInstance()
        {
            var islandExplorer = new IslandExplorer();
        }

        [TestMethod]
        public void checkLimitDimensionOfGrid_exceed()
        {
            int[] exceedGrid = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            };

            var islandExplorer = new IslandExplorer();

            Assert.IsTrue(islandExplorer.checkLimitDimension(exceedGrid));
        }

        [TestMethod]
        public void checkLimitDimensionOfGrid_normal()
        {
            int[] normalGrid = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            };

            var islandExplorer = new IslandExplorer();

            Assert.IsFalse(islandExplorer.checkLimitDimension(normalGrid));
        }

        [TestMethod]
        public void findZeroIsland()
        {
            int[] zeroIslandGrid = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(0, islandExplorer.search(zeroIslandGrid));
        }

        [TestMethod]
        public void findOneIsland()
        {
            int[] oneIslandGrid = new int[]
            {
                0, 0, 0, 1, 0, 0, 0, 0, 0, 0,
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(1, islandExplorer.search(oneIslandGrid));
        }

        [TestMethod]
        public void findMaxIsland2()
        {
            int[] twoIslandGrid = new int[]
            {
                0, 0, 0, 1, 0, 1, 1, 0, 0, 0,
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(2, islandExplorer.search(twoIslandGrid));
        }

        [TestMethod]
        public void findMaxIsland3()
        {
            int[] threeIslandGrid = new int[]
            {
                0, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 0, 0,
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(4, islandExplorer.search(threeIslandGrid));
        }
    }
}

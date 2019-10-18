using System;
using MaxAreaOfIsland3;
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
        public void findOneSizeIsland()
        {
            int[][] islandGrid = new int[][]
            {
                new int [] { 0, 0, 0 },
                new int [] { 0, 1, 0 },
                new int [] { 0, 0, 0 },
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(1, islandExplorer.search(0, 0, islandGrid));
        }

        [TestMethod]
        public void findTwoSizeIsland()
        {
            int[][] islandGrid = new int[][]
            {
                new int [] { 0, 1, 0 },
                new int [] { 0, 1, 0 },
                new int [] { 0, 0, 0 },
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(2, islandExplorer.search(0, 0, islandGrid));
        }

        [TestMethod]
        public void findThreeSizeIsland()
        {
            int[][] islandGrid = new int[][]
            {
                new int [] { 0, 1, 0 },
                new int [] { 0, 1, 0 },
                new int [] { 0, 1, 0 },
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(3, islandExplorer.search(0, 0, islandGrid));
        }
    }
}

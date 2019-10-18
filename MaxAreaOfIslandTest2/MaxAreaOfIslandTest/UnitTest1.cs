using System;
using MaxAreaOfIslandTest2;
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
        public void checkGridLength()
        {
            int[][] islandGrid = new int[][]
            {
                new int [] { 0, 0, 0 },
                new int [] { 0, 0, 0 },
                new int [] { 0, 0, 0 },
            };

            var islandExplorer = new IslandExplorer();

            Assert.IsTrue(islandExplorer.checkGridLength(islandGrid));
        }

        [TestMethod]
        public void getGridRowAndColumnLength()
        {
            int[][] islandGrid = new int[][]
            {
                new int [] { 0, 0, 0 },
                new int [] { 0, 0, 0 },
                new int [] { 0, 0, 0 },
                new int [] { 0, 0, 0 },
            };

            Assert.AreEqual(4, islandGrid.Length);
            Assert.AreEqual(3, islandGrid[0].Length);
        }

        [TestMethod]
        public void checkOneSizeIsland_Down()
        {
            int[][] islandGrid = new int[][]
            {
                new int [] { 1, 0, 0 },
                new int [] { 0, 1, 0 },
                new int [] { 0, 0, 1 },
            };

            var islandExplorer = new IslandExplorer();

            Assert.IsTrue(islandExplorer.checkGridLength(islandGrid));
            Assert.AreEqual(1, islandExplorer.search(0, 0, islandGrid));
        }

        [TestMethod]
        public void checkTwoSizeIsland_Down()
        {
            int[][] islandGrid = new int[][]
            {
                new int [] { 1, 0, 0 },
                new int [] { 1, 0, 0 },
                new int [] { 0, 0, 1 },
            };

            var islandExplorer = new IslandExplorer();

            Assert.IsTrue(islandExplorer.checkGridLength(islandGrid));
            Assert.AreEqual(2, islandExplorer.search(0, 0, islandGrid));
        }

        [TestMethod]
        public void checkThreeSizeIsland_Down()
        {
            int[][] islandGrid = new int[][]
            {
                new int [] { 1, 0, 0 },
                new int [] { 1, 0, 0 },
                new int [] { 1, 0, 1 },
            };

            var islandExplorer = new IslandExplorer();

            Assert.IsTrue(islandExplorer.checkGridLength(islandGrid));
            Assert.AreEqual(3, islandExplorer.search(0, 0, islandGrid));
        }

        [TestMethod]
        public void checkFourSizeIsland_Down()
        {
            int[][] islandGrid = new int[][]
            {
                new int [] { 1, 0, 0 },
                new int [] { 1, 0, 0 },
                new int [] { 1, 0, 1 },
                new int [] { 1, 0, 1 },
            };

            var islandExplorer = new IslandExplorer();

            Assert.IsTrue(islandExplorer.checkGridLength(islandGrid));
            Assert.AreEqual(4, islandExplorer.search(0, 0, islandGrid));
        }

        [TestMethod]
        public void checkTwoSizeIsland_Right()
        {
            int[][] islandGrid = new int[][]
            {
                new int [] { 1, 1, 0 },
                new int [] { 0, 0, 0 },
                new int [] { 0, 0, 1 },
            };

            var islandExplorer = new IslandExplorer();

            Assert.IsTrue(islandExplorer.checkGridLength(islandGrid));
            Assert.AreEqual(2, islandExplorer.search(0, 0, islandGrid));
        }
    }
}

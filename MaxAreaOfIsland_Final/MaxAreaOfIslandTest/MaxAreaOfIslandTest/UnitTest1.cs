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
        public void findOneIsland()
        {
            int[][] islandGrid = new int[][]
            {
                new int[] {0, 0, 0},
                new int[] {0, 1, 0},
                new int[] {0, 0, 0},
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(1, islandExplorer.MaxAreaOfIsland(islandGrid));
        }

        [TestMethod]
        public void findConnectedTwoIsland()
        {
            int[][] islandGrid = new int[][]
            {
                new int[] {0, 1, 0},
                new int[] {0, 1, 0},
                new int[] {0, 0, 0},
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(2, islandExplorer.MaxAreaOfIsland(islandGrid));
        }

        [TestMethod]
        public void findConnectedThreeIsland()
        {
            int[][] islandGrid = new int[][]
            {
                new int[] {0, 1, 0},
                new int[] {0, 1, 0},
                new int[] {0, 1, 0},
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(3, islandExplorer.MaxAreaOfIsland(islandGrid));
        }

        [TestMethod]
        public void findConnectedFourIsland()
        {
            int[][] islandGrid = new int[][]
            {
                new int[] {0, 1, 0},
                new int[] {1, 1, 0},
                new int[] {0, 1, 0},
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(4, islandExplorer.MaxAreaOfIsland(islandGrid));
        }

        [TestMethod]
        public void findConnectedFiveIsland()
        {
            int[][] islandGrid = new int[][]
            {
                new int[] {0, 1, 0},
                new int[] {1, 1, 1},
                new int[] {0, 1, 0},
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(5, islandExplorer.MaxAreaOfIsland(islandGrid));
        }

        [TestMethod]
        public void findConnectedFourIsland_leetcode()
        {
            int[][] islandGrid = new int[][]
            {
                new int[] {1, 1, 0, 0},
                new int[] {1, 1, 0, 0},
                new int[] {0, 0, 1, 1},
                new int[] {0, 0, 1, 1},
            };

            var islandExplorer = new IslandExplorer();

            Assert.AreEqual(4, islandExplorer.MaxAreaOfIsland(islandGrid));
        }
    }
}

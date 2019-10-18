using System;

namespace MaxAreaOfIslandTest2
{
    public class IslandExplorer
    {
        public IslandExplorer()
        {
        }

        public bool checkGridLength(int[][] islandGrid)
        {
            return (islandGrid.Length < 50 || islandGrid[0].Length < 50);
        }
#if false
        public int search(int row, int column, int[][] islandgrid)
        {
            int maxIslandSize = 0;
            int islandCount = 0;

            if (row < 0 || column < 0) return 0;

            for (int i = row; i < islandgrid.Length; i++)
            {
                for (int j = column; j < islandgrid[0].Length; j++)
                {
                    if (islandgrid[i][j] == 1)
                    {
                        // find down direction
                        islandCount++;
                        islandCount += searchDown(i + 1, j, islandgrid);

                        if (islandCount > maxIslandSize)
                        {
                            maxIslandSize = islandCount;
                        }
                    }
                    else
                    {
                        islandCount = 0;
                    }
                }
            }

            return maxIslandSize;
        }
#else
        public int search(int row, int column, int[][] islandgrid)
        {
            int maxIslandSize = 0;
            int islandCount = 0;

            if (row < 0 || column < 0) return 0;

            // find down direction
            islandCount += searchDown(row, column, islandgrid);

            if (islandCount > maxIslandSize)
            {
                maxIslandSize = islandCount;
            }

            return maxIslandSize;
        }
#endif
        private int searchDown(int row, int column, int[][] islandgrid)
        {
            int find = 0;

            if (row > islandgrid.Length - 1) return 0;

            if (islandgrid[row][column] == 1)
            {
                find = 1;
                find += searchDown(row + 1, column, islandgrid);
            }

            return find;
        }
    }
}
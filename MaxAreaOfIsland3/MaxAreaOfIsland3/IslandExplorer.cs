using System;

namespace MaxAreaOfIsland3
{
    public class IslandExplorer
    {
        public IslandExplorer()
        {
        }

        public int search(int row, int column, int[][] islandGrid)
        {
            int islandCount = 0;
            int maxAreaOfIslandCount = 0;
            bool[,] visited = new bool[islandGrid.Length, islandGrid[0].Length];

            if ((row > 0 && row < islandGrid.Length - 1) && (column > 0 && column < islandGrid[0].Length - 1))
                return 0;

            for (int i = row; i < islandGrid.Length; i++)
            {
                for (int j = column; j < islandGrid[0].Length; j++)
                {
                    if (islandGrid[i][j] == 1)
                    {
                        islandCount++;
                        visited[i, j] = true;

                        if ((i > 0 && i < islandGrid.Length - 1) && (j > 0 && j < islandGrid[0].Length - 1))
                        {
                            if (islandGrid[i + 1][j] == 1)
                            {
                                islandCount++;
                                if (islandCount > maxAreaOfIslandCount)
                                    maxAreaOfIslandCount = islandCount;
                            }
                            else
                            {
                                islandCount = 0;
                            }
                        }
                    }
                }
            }

            return maxAreaOfIslandCount;
        }
    }
}
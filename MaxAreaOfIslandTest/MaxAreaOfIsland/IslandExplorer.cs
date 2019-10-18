using System;

namespace MaxAreaOfIsland
{
    public class IslandExplorer
    {
        public IslandExplorer()
        {
        }

        public bool checkLimitDimension(int[] grid)
        {
            return (grid.Length > 50); 
        }

        public int search(int[] grid)
        {
            int islandSize = 0;
            int maxIslandSize = 0;

            if (checkLimitDimension(grid)) return 0;

            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i] == 1)
                {
                    islandSize++;
                }
                else
                {
                    if (islandSize > maxIslandSize)
                        maxIslandSize = islandSize;

                    islandSize = 0;
                }
            }

            return maxIslandSize;
        }
    }
}
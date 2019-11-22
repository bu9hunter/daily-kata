using System;

namespace MaxAreaOfIsland
{
    public class IslandExplorer
    {
        public IslandExplorer()
        {
        }

        public int MaxAreaOfIsland(int[][] grid)
        {
            int islandCount = 0;
            int maxIslandCount = 0;

            // 그리드 전체 순회하기
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    // 땅 찾기
                    if (grid[i][j] == 1)
                    {
                        // 중앙 땅 찾음
                        islandCount++;
                        // 상,하,좌,우 방향으로 찾기
                        // 상 방향 찾기
                        if (i - 1 >= 0)
                        {
                            if (grid[i - 1][j] == 1) islandCount++;
                        }

                        // 하 방향 찾기
                        if (i + 1 <= grid.Length - 1)
                        {
                            if (grid[i + 1][j] == 1) islandCount++;
                        }

                        // 좌 방향 찾기
                        if (j - 1 >= 0)
                        {
                            if (grid[i][j - 1] == 1) islandCount++;
                        }

                        // 우 방향 찾기
                        if (j + 1 <= grid[0].Length - 1)
                        {
                            if (grid[i][j + 1] == 1) islandCount++;
                        }

                        // 최대값 갱신하기
                        if (islandCount > maxIslandCount) maxIslandCount = islandCount;
                    }
                    islandCount = 0;
                }
            }

            return maxIslandCount;
        }

        private int fi
    }
}
class Solution {
    public int[] findBall(int[][] grid) {
        int[] ans = new int[grid[0].length];
        for(int ball = 0; ball < grid[0].length; ball++)
        {
            int currentPos = ball;
            for(int row = 0; row < grid.length; row++)
            {
                int nextPos = currentPos + grid[row][currentPos];
                if(nextPos < 0 || nextPos >= grid[0].length ||
                  grid[row][currentPos] != grid[row][nextPos])
                {
                    ans[ball] = -1;
                    break;
                }
                ans[ball] = nextPos;
                currentPos = nextPos;
            }
        }
        return ans;
    }
}
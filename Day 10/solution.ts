function findBall(grid: number[][]): number[] {
    const ans = new Array<number>();
    for(let ball = 0; ball < grid[0].length; ball++)
    {
        let currentPos =  ball;
        for(let row = 0; row < grid.length; row++)
            {
                var nextPos = currentPos + grid[row][currentPos];
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
};
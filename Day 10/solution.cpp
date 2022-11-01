class Solution {
public:
    vector<int> findBall(vector<vector<int>>& grid) {
        int rows = grid.size(), cols = grid[0].size();
        int dp[rows + 1][cols];
        memset(dp, 0, sizeof(dp));
        for(int c = 0; c < cols; c++) dp[rows][c] = c;
        for(int r = rows - 1; r >= 0; r--){
            for(int c = 0; c < cols; c++){
                int nc = c + grid[r][c]; // next column
                if(nc < 0 || nc > cols - 1 || grid[r][c] != grid[r][nc]) dp[r][c] = -1;
                else dp[r][c] = dp[r + 1][nc];
            }
        }
        vector<int> res(cols, 0);
        for(int c = 0; c < cols; c++) res[c] = dp[0][c];
        return res;
    }
};

//1/11/2022
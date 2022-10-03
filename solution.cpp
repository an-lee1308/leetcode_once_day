bool dfs (vector<vector<char>> &grid, string word, int i , int j, vector<vector<int>> &res) {
  if (word == "") return true;
 
  // check input parameter here
  // check valid i & j
  if (i < 0 || j < 0 || i >= grid.size() || j >= grid[0].size() ) return false;
 
  // check gird[i][j] == word[0]
  if(grid[i][j] != word[0]) return false;
  res.push_back({i,j});
 
  if (!dfs (grid, word.substr(1), i+1, j, res)  && !dfs (grid, word.substr(1), i, j+1, res)) {
    res.pop_back();
[B]    return false;[/B]
  }
  return true;
}

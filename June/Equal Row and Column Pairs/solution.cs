public class Solution {
  const int BASE = 5119;
  const int MOD = 1000000007;

  public int EqualPairs(int[][] grid) {
    int n = grid.Length;
    long[] row_hash = new long[n];

    int res = 0;

    // rows
    for (int i = 0; i < n; i++) {
      long h = 0;
      for (int j = 0; j < n; j++) h = (h * BASE + grid[i][j]) % MOD;
      row_hash[i] = h;
    }

    // cols
    for (int j = 0; j < n; j++) {
      long h = 0;
      for (int i = 0; i < n; i++) h = (h * BASE + grid[i][j]) % MOD;

      for (int i = 0; i < n; i++) res += row_hash[i] == h ? 1 : 0;
    }

    return res;
  }
}
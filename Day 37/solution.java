class Solution {
  public int minFallingPathSum(int[][] matrix) {
    int M = matrix.length;
    for (int i = M-2; i >= 0; --i) {
      for (int j = 0; j < M; ++j) {
        int v = matrix[i][j];
        int d = matrix[i+1][j];
        int l, r;
        l = r = Integer.MAX_VALUE/2;
        if (j+1 < M) r = matrix[i+1][j+1];
        if (j-1 >= 0) l = matrix[i+1][j-1];
        matrix[i][j] = Math.min(v+d, Math.min(v+l, v+r));
      }
    }
      
    int min = Integer.MAX_VALUE;
    for (int i = 0; i < M; ++i) min = Math.min(min, matrix[0][i]);
    return min;
  }
}
class Solution {
    public int longestCommonSubsequence(String text1, String text2) {


        char[] c1 = text1.toCharArray();
        char[] c2 = text2.toCharArray();

        if (c1.length < 2 && c2.length < 2) {
            return c1[0] == c2[0] ? 1 : 0;
        }

        int[][] dp = new int[c1.length + 1][c2.length + 1];

          for (int i = 1; i < c1.length + 1; i++) {
            for (int j = 1; j < c2.length + 1; j++) {
                if (c1[i - 1] == c2[j - 1]) {
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                } else {
                    dp[i][j] = Math.max(dp[i][j - 1], dp[i - 1][j]);
                }
            }
        }

        return dp[c1.length][c2.length];
    }
}
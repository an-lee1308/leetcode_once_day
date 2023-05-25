public class Solution {
    public double New21Game(int n, int k, int maxPts) {
        if (k == 0 || n >= k + maxPts) return 1;

        double[] dp = new double[n + 1];
        double sumTill = 1, res = 0;
        dp[0] = 1;

        for (int i = 1; i <= n; ++i) {
            dp[i] = sumTill / maxPts;
            if (i < k) 
                sumTill += dp[i]; 
            else  
                res += dp[i];

            if (i - maxPts >= 0) 
                sumTill -= dp[i - maxPts];
        }

        return res;
    }
}
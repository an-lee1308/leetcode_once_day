class Solution:
    def rob(self, nums: List[int]) -> int:
        n = len(nums)
        dp = [-1 for i in range(n + 2)]
        return self.recur(nums, dp, n - 1)

        
    def recur(self, nums, dp, n) -> int:
        if n < 0:
            return 0
        elif dp[n] >= 0:
            return dp[n]
        ans = max(self.recur(nums, dp, n - 2) + nums[n], self.recur(nums, dp, n - 1))
        dp[n] = ans
        return dp[n]
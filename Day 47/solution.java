class Solution {
    public boolean canJump(int[] nums) {
        int sz = nums.length;
        int maxPos = nums[0];
        for (int i = 1; i <= maxPos; ++i) {
            if (maxPos >= sz) return true;
            maxPos = Math.max(maxPos, i + nums[i]);
        }
        return maxPos >= sz-1;
    }
}
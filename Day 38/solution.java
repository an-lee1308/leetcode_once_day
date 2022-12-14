class Solution {
  public int rob(int[] nums) {
    Map<Integer, Integer> maxMoneyForRob = new HashMap<>();
    for (int i = 0; i < nums.length; ++i) {
      int curr = maxMoneyForRob.getOrDefault(i-2, 0) + nums[i];
      maxMoneyForRob.put(i, Math.max(curr, maxMoneyForRob.getOrDefault(i-1, 0)));
    }
    return maxMoneyForRob.get(nums.length-1);
  }
}
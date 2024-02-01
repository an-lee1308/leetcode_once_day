public class Solution {
    public int[][] DivideArray(int[] nums, int k) {

        int[][] output = new int[nums.Length / 3][];

        Array.Sort(nums);

        for (int i = 2; i < nums.Length; i += 3)
        {
            if (nums[i] - nums[i - 1] <= k && nums[i] - nums[i - 2] <= k)
            {
                int[] array = new int[3]{nums[i], nums[i - 1], nums[i - 2]};

                output[(i + 1) / 3 - 1] = array;
            }
            else
            {
                return [];
            }
        }

        return output;
    }
}
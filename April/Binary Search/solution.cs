public class Solution {
    public int Search(int[] nums, int target) {

      // return nums.ToList().IndexOf(target);

      int minIndex = 0;
      int maxIndex = nums.Length;


      if (nums.Length == 0)
      {
          return -1;
      }

      while(true)
      {
          int mid = (minIndex + maxIndex) / 2;

          if (mid >= maxIndex)
          {
              return -1;
          }

          if (target == nums[mid])
          {
              return mid;
          }

          if (target > nums[mid])
          {
              minIndex = mid + 1;
          }

          if (target < nums[mid])
          {
              maxIndex = mid;
          }

      }

        

    }
}
public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {

        long result = 0;
        long sum = 0;
        PriorityQueue<int, int> heap = new();
        
        Array.Sort(nums2, nums1);

        for (int i = 1; i <= k; i++)  {
            sum += nums1[^i];
            heap.Enqueue(nums1[^i], nums1[^i]);
        }
        result = sum * nums2[^k];

        for (int i = k + 1; i <= nums1.Length; i++) {
            sum = sum + nums1[^i] - heap.EnqueueDequeue(nums1[^i], nums1[^i]);
            result = Math.Max(result, result = sum * nums2[^i]);
        }

        return result;
    }
}
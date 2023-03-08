public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1,
            right = piles.Max();
        int result = right;

        while(left <= right) {
            int middle = left + (right - left) / 2;

            int hours = 0;
            foreach(int pile in piles) {
                hours += (int)Math.Ceiling((double)pile / (double)middle);
            }

            if(hours < 0) break;

            if(hours <= h) {
                result = Math.Min(result, middle);
                Console.WriteLine($"{hours} and {middle}: {result}");
                right = middle - 1;
            } else {
                left = middle + 1;
            }
        }

        return result;
    }
}
class Solution {
public:
    int guessNumber(int n) {
        int low = 1, high = n;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            switch (guess(mid))
            {
            case -1:
                high = mid - 1;
                break;

            case 1:
                low = mid + 1;
                break;
            
            default:
                return mid;
                break;
            }
        }

        return -1;
    }
};
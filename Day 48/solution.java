class Solution {
    public int maximumBags(int[] capacity, int[] rocks, int additionalRocks) {
        int[] remains = new int[capacity.length];

        for (int i = 0; i < capacity.length; i++) {
            remains[i] = capacity[i] - rocks[i];
        }

        Arrays.sort(remains);
        int cnt = 0;
        for (int i = 0; i < remains.length; i++) {
            if (additionalRocks < remains[i]) return cnt;
            additionalRocks -= remains[i];
            cnt++;
        }

        return cnt;
    }
}
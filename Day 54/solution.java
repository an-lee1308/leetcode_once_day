class Solution {
    public int minimumRounds(int[] tasks) {
        int ans = 0;
        Map<Integer, Integer> map = new HashMap<>();
        for (int t : tasks) {
            map.compute(t, (k, v) -> {
                if (v == null) v = 0;
                ++v;
                return v;
            });
        }

        for (Map.Entry<Integer, Integer> e : map.entrySet()) {
            int value = e.getValue();
            if (value == 1) return -1;
            if (value % 3 == 0) ans += value/3;
            else ans += value/3+1;
        }

        return ans;
    }
}
class Solution {
    public int minStoneSum(int[] piles, int k) {
        PriorityQueue<Integer> heap = new PriorityQueue<>((a, b) -> b - a);

        for (int pile : piles) heap.add(pile);

        for (int i = 0; i < k; i++) {
            int pile = heap.poll();
            heap.add(pile - pile/2);
        }

        int ans = 0;
        while(!heap.isEmpty()) {
            ans += heap.poll();
        }

        return ans;
    }
}
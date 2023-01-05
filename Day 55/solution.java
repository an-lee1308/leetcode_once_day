class Solution {
    class Ballon {
        Integer start, end;
        public Ballon(){}
        public Ballon(int start, int end) {
            this.start = start;
            this.end = end;
        }
    }
    public int findMinArrowShots(int[][] points) {
        List<Ballon> bList = new ArrayList<>();
        for (int [] b : points) {
            bList.add(new Ballon(b[0], b[1]));
        }
        bList.sort((a, b) -> {
            if (a.start == b.start) return a.end.compareTo(b.end);
            return a.start.compareTo(b.start);
        });

        int ans = 0;
        for (int i = 0, sz = bList.size(); i < sz;) {
            Ballon crr = bList.get(i);
            boolean counted = false;
            for (int j = i + 1; j < sz; ++j) {
                Ballon ptr = bList.get(j);
                if (ptr.start > crr.end) {
                    ++ans;
                    i = j;
                    counted = true;
                    break;
                }
                    crr.start = Math.max(crr.start, ptr.start);
                    crr.end = Math.min(crr.end, ptr.end);
            }
            if (!counted) {
                ++ans;
                break;
            }
        }

        return ans;
    }
}
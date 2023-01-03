class Solution {
    public int minDeletionSize(String[] strs) {
        int length = strs[0].length();
        int cnt = 0;
        for (int i = 0; i < length; i++) {
            for (int j = 1; j < strs.length; j++) {
                if (strs[j].charAt(i) < strs[j-1].charAt(i)){
                    cnt++;
                    break;
                }
            }
        }

        return cnt;
    }
}
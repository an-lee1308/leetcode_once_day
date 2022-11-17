class Solution {
    public int computeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        int xOverlapped = 0;
        int yOverlapped = 0;
        
        if (ax2 < bx1 || bx2 < ax1) xOverlapped = 0; // x not overlapped
        else xOverlapped = Math.min(ax2, bx2) - Math.max(ax1, bx1);
        
        if (ay2 < by1 || by2 < ay1) yOverlapped = 0; // y not overlapped
        else yOverlapped = Math.min(by2, ay2) - Math.max(ay1, by1);
        
        return (ax2-ax1) * (ay2-ay1) + (bx2-bx1) * (by2-by1) - xOverlapped*yOverlapped;
    }
}
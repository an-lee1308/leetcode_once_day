class Solution {
public:
    int largestOverlap(vector<vector<int>>& img1, vector<vector<int>>& img2) {
        int n = img1.size(), res = 0;
        vector<int64_t> bits1(n), bits2(n);
        for (int r = 0; r < n; ++r)
            for (int c = 0; c < n; ++c) {
                bits1[r] |= (img1[r][c] - 0) << c;
                bits2[r] |= (img2[r][c] - 0) << c;
            }

        // left / right shift
        for (int l = -n + 1; l < n; ++l) {
            // up / down shift
            for (int u = -n + 1; u < n; ++u) {
                int cnt = 0;
                for (int r = 0; r < n; ++r) {
                    auto r1 = (((r + u >= 0) & (r + u < n)) ? bits1[r + u] : 0);
                    r1 = (l >= 0) ? r1 >> l : r1 << (-l);
                    cnt += __builtin_popcount(r1 & bits2[r]);
                }
                res = max(cnt, res);
            }
        }
        return res;
    }
};
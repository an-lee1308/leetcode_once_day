class Solution {
public:
    int maxLength(vector<string>& arr) {
        int n = arr.size(), res = 0;
        vector<int> complex; complex.reserve(1 << n); complex.emplace_back(0);
        for (int i = 0, bits = 0; i < arr.size(); ++i, bits = 0) {
            for (auto c : arr[i]) bits |= 1 << (c - 'a');
            if (__builtin_popcount(bits) != arr[i].size()) continue;
            for (int j = 0, je = complex.size(); j < je; ++j)
                if (auto c = complex[j]; !(bits & c)) {
                    complex.emplace_back(bits | c);
                    auto cnt = __builtin_popcount(bits | c);
                    res ^= (res ^ cnt) & -(res < cnt); // res = max(res, __builtin_popcount(bits | c));
                }
        }
        return res;
    }
};

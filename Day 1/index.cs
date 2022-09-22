class Solution {
public:
    vector<int> sumEvenAfterQueries(vector<int>& nums, vector<vector<int>>& queries) {
        vector<int> res; res.reserve(queries.size());
        int sum = 0;
        for (auto i : nums) sum += i & ((i & 1) - 1);
        for (auto &v : queries) {
            auto &n = nums[v[1]];
            sum -= n & ((n & 1) - 1);
            n += v[0];
            res.emplace_back(sum += n & ((n & 1) - 1));
        }
        return res;
    }
};
class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        return accumulate(next(nums.begin()), nums.end(), 1, [it=next(nums.begin())](int acc, int &x) mutable {
            return (x != *(&x-1)) ? (*it++ = x, acc + 1) : acc;
        });
    }
};
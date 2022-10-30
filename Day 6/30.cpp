/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
    array<int, 100'001> level, heigh;
    array<pair<int, int>, 100'001> mh; // 2 max heigh of each level
    
    int scan(TreeNode *n, int l) {
        if (!n) return 0;
        auto h = heigh[n->val] = 1 + max(scan(n->left, l+1), scan(n->right, l+1));
        if (auto &p = mh[level[n->val] = l]; h > p.first) p = minmax(h, p.second);
        return h;
    }
    
public:
    vector<int> treeQueries(TreeNode* root, vector<int>& queries) {
        vector<int> res(queries.size());
        scan(root, 0);
        transform(begin(queries), end(queries), begin(res), [&, h0 = mh[0].second](auto q) {
            auto l = level[q]; auto [mx2, mx] = mh[l];
            return heigh[q] == mx ? l + mx2 - 1 :  h0 - 1;
        });
        return res;
    }
};

//https://leetcode.com/submissions/detail/833269728/

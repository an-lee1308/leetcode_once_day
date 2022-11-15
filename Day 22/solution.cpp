class Solution {
public:
    int countNodes(TreeNode* root) {
        if (!root) return 0;
        int h = 1;
        for (auto n = root; n->left; n = n->left, ++h);
        if (h == 1) return 1;
        
        auto check = [=](TreeNode* root, int pos) {
            for (auto mask = 1 << (h - 2); mask; mask >>= 1) {
                if (pos & mask) root = root->right;
                else root = root->left;
            }
            return root != nullptr;
        };
        
        // binary search from (2^(h-1) --> 2^h - 1)
        int l = 1 << (h-1), r = 1 << h;
        while (l < r) {
            int mid = (l + r) >> 1;
            if (check(root, mid))
                l = mid + 1;
            else
                r = mid;
        }
        return l - 1;
    }
};
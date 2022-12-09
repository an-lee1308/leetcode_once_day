class Solution:
    def maxAncestorDiff(self, root: Optional[TreeNode], curMax = 0, curMin = 1000000) -> int:
        return max(self.maxAncestorDiff(root.left, max(curMax, root.val), min(curMin, root.val)), self.maxAncestorDiff(root.right, max(curMax, root.val), min(curMin, root.val))) if root else curMax - curMin
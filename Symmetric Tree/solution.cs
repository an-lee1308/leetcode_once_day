public class Solution {
    public bool IsSymmetric(TreeNode root) => CheckSymetry(root?.left, root?.right);
    
    private bool CheckSymetry(TreeNode left, TreeNode right)
    {
        if(left == null || right == null)
            return left?.val == right?.val;
        if(left.val != right.val)
            return false;

        return CheckSymetry(left.left, right.right) && CheckSymetry(left.right, right.left);
    }
}
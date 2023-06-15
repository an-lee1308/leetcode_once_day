public class Solution {
    public int MaxLevelSum(TreeNode root) {
        int lvl = 0, max_sum = Int32.MinValue, count = 0;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        // Level by level traverse
        while (q.Count>0){
            count ++;
            int curr_sum = 0, c = q.Count;
            for (int i=0; i<c; i++) {
                var nn = q.Dequeue();
                curr_sum += nn.val;
                if (nn.left != null) q.Enqueue(nn.left);
                if (nn.right != null) q.Enqueue(nn.right);
            }
            // Adjust max_sum and lvl if needed
            if (max_sum<curr_sum){
                (max_sum, lvl) = (curr_sum, count);
            }
        }
        return lvl;
    }
}

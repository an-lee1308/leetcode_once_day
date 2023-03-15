public class Solution {
    public bool IsCompleteTree(TreeNode root) {
        
        Queue<TreeNode> bfs = new Queue<TreeNode>();
        bfs.Enqueue(root);

        while (bfs.Any())
        {
            var node = bfs.Dequeue();

            if (node == null)
                return !bfs.Any(x => x != null);

            bfs.Enqueue(node.left);
            bfs.Enqueue(node.right);                    
        }
        return false;
    }
}
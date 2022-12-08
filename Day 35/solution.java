Java:
class Solution {
    public boolean leafSimilar(TreeNode root1, TreeNode root2) {
        // Iterative approach
        List<Integer> l1 = new ArrayList<>();
        List<Integer> l2 = new ArrayList<>();
        postOrder(root1, l1);
        postOrder(root2, l2);
        return l1.equals(l2);
    }
    private void postOrder(TreeNode root, List<Integer> l)
    {
        Stack<TreeNode> s = new Stack<>();
        HashSet<TreeNode> visited = new HashSet<>();
        s.push(root);
        while(!s.isEmpty())
        {
            TreeNode curr = s.peek();
            if(!visited.contains(curr))
            {
                visited.add(curr);
                if(curr.right != null)
                {
                    s.push(curr.right);
                }
                if(curr.left != null)
                {
                    s.push(curr.left);
                }
            }
            else
            {
                if(curr.left == null && curr.right == null)
                {
                    l.add(curr.val);
                }
                visited.remove(s.pop());
            }

        }
    }
}
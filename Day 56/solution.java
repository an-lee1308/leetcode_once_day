class Solution {
    public List<Integer> preorderTraversal(TreeNode root) {
        if(root == null){
            return new ArrayList<>();
        }
        Stack<TreeNode> st = new Stack<>();
        List<Integer> ans = new ArrayList<>();
        st.push(root);
        while(!st.isEmpty()){
            TreeNode current = st.pop();
            ans.add(current.val);
            if(current.right != null){
                st.push(current.right);
            }
            if(current.left != null){
                st.push(current.left);
            }
        }
        return ans;
    }
}
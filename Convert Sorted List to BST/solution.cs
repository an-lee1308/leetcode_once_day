/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {
        TreeNode tree = null;
            List<int> ints = new List<int>();
            while (head != null)
            {
                ints.Add(head.val);
                head = head.next;
            }
            tree = insertBST(tree, ints, 0, ints.Count - 1);
            return tree;

            return tree;
    }
 public static TreeNode insertBST(TreeNode root, List<int> values, int left, int right)
        {
           if (left > right)
                return root;
            int mid = left + (right - left) / 2;
            root = new TreeNode(values[mid]);
            root.left = insertBST(root.left, values, left, mid - 1);
            root.right = insertBST(root.right, values, mid + 1, right);
            return root;
        }
}
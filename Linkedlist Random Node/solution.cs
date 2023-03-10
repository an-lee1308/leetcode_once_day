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
public class Solution {
    private ListNode head;
    private int count;
    private Random random;
    public Solution(ListNode head) {
        this.head = head;
        count = 0;
        var curr = head;
        while (curr != null)
        {
            count++;
            curr = curr.next;
        }
        random = new Random();
    }
    
    public int GetRandom() {
        var curr = head;
        var limit = random.Next(count);
        for (int i = 0; i < limit; i++) curr = curr.next;
        return curr.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */
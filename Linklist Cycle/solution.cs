public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var set = new HashSet<ListNode>();
        
        while (head != null)
        {
            if (set.Contains(head))
                break;
            
            set.Add(head);
            head = head.next;
        }

        return head;
    }
}
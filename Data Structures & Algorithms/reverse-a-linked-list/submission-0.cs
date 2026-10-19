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
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null) {
            ListNode next = curr.next;   // 1. SAVE where you're going
            curr.next = prev;          // 2. FLIP the arrow backward
            prev = curr;               // 3. MOVE prev forward (to the node just reversed)
            curr = next;               // 3. MOVE curr forward (to the saved node)
        }
        
        return prev;
    }
}

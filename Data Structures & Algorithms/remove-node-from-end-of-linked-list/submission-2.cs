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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var curr = head;
        int count = 0;
        while (curr != null) {
            count++;
            curr = curr.next;
        }
        if (count == n)
            return head.next;
        int removeIdx = count - n;
        curr = head;
        ListNode prev = null;

        while (removeIdx >= 0) {
            if (removeIdx == 0) {
                if (prev != null && curr != null)
                    prev.next = curr.next;
            }
            prev = curr;
            curr = curr.next;
            removeIdx--;
        }
        return head;
    }
}

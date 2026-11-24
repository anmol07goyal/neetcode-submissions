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
        // use 2 pointers. both n distance apart. when right is null, l should be the node to delete. 
        //but we need the ref to the prev node to remove the correct node.
        //so we get a dummy node and point it at head. 
        //now left starts from dummy.
        ListNode dummy = new ListNode(0, head);
        ListNode l = dummy, r = head;
        while (n > 0 && r != null) {
            r = r.next;
            n--;
        }

        while (r != null) {
            l = l.next;
            r = r.next;
        }

        l.next = l.next.next;
        return dummy.next;
    }
}
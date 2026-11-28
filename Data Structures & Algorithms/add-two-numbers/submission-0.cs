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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        var head = new ListNode();
        var dummy = head;
        while (l1 != null || l2 != null) {
            int n1 = l1 == null ? 0 : l1.val;
            int n2 = l2 == null ? 0 : l2.val;
            int n3 = n1 + n2 + carry;
            carry = n3 / 10;
            dummy.val = n3 % 10;
            l1 = l1?.next;
            l2 = l2?.next;
            dummy.next = l1 == null && l2 == null ? null : new ListNode();
            if (dummy.next != null)
                dummy = dummy.next;
        }

        if (carry != 0)
            dummy.next = new ListNode(carry);

        return head;
    }
}
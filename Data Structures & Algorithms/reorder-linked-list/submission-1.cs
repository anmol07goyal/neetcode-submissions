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
    public void ReorderList(ListNode head) {
        if (head.next == null)
            return;
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        // so our mid point is at the slow
        ListNode newHead = ReverseList(slow.next);
        slow.next = null;
        ListNode c1 = head, c2 = newHead;

        while (c1 != null && c2 != null) {
            var temp = c1.next;
            c1.next = c2;
            c1 = c1.next;
            c2 = temp;
        }
    }

    public void Print(ListNode head) {
        while(head!=null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();
    }

    public ListNode ReverseList(ListNode head) {
        ListNode prev = null, curr = head;
        while (curr != null) {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null)
            return list2;
        else if (list2 == null)
            return list1;

        ListNode curr1 = list1, curr2 = list2;
        while (curr1 != null && curr2 != null) {
            if (curr1.val <= curr2.val) {
                var temp = curr1.next;
                if (temp == null || temp.val > curr2.val)
                    curr1.next = curr2;
                curr1 = temp;
            } else {
                var temp = curr2.next;
                if (temp == null || temp.val > curr1.val)
                    curr2.next = curr1;
                curr2 = temp;
            }
        }

        return list1.val <= list2.val ? list1 : list2;
    }
}
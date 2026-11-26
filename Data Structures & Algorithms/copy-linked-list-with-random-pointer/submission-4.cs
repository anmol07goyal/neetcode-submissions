/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null)
            return null;
        Dictionary<Node, Node> storage = new();
        var temp = head;
        while (temp != null) {
            Node copy = new(temp.val);
            storage.Add(temp, copy);
            temp = temp.next;
        }

        temp = head;
        while (temp != null) {
            var copy = storage[temp];
            copy.next = temp.next == null ? null : storage[temp.next];
            copy.random = temp.random == null ? null : storage[temp.random];
            temp = temp.next;
        }
        
        return storage[head];
    }
}

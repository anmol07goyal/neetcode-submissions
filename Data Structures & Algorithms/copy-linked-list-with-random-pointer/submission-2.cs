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
        List<Node> store = new();
        Dictionary<Node, int> storage = new();
        var temp = head;
        int count = 0;
        while (temp != null) {
            Node node = new(temp.val);
            store.Add(node);
            storage.Add(temp, count++);
            temp = temp.next;
        }
        int i = 0;
        while (head != null) {
            if (i >= count)
                break;
            if (i < count - 1)
                store[i].next = store[i + 1];
            if (head.random != null && storage.ContainsKey(head.random)) {
                var idx = storage[head.random];
                store[i].random = store[idx];
            }
            head = head.next;
            i++;
        }

        return store[0];
    }
}

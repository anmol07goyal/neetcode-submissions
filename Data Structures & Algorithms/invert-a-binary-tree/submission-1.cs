/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
            return null;
        var store = new Queue<TreeNode>();
        store.Enqueue(root);
        while (store.Count > 0) {
            var node = store.Dequeue();
            var tmp = node.left;
            node.left = node.right;
            node.right = tmp;
            if (node.left != null)
                store.Enqueue(node.left);
            if (node.right != null)
                store.Enqueue(node.right);
        }
        return root;
    }
}

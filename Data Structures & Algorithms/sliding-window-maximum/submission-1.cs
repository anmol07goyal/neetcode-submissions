public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var maxHeap = new PriorityQueue<(int val, int idx), int>(
            Comparer<int>.Create((x, y) => y.CompareTo(x)));

        int[] output = new int[nums.Length - k + 1];
        int idx = 0;

        for (int i = 0; i < nums.Length; i++) {
            maxHeap.Enqueue((nums[i], i), nums[i]);
            if (i >= k - 1) {
                while (maxHeap.Peek().idx <= i - k) 
                    maxHeap.Dequeue();
                output[idx++] = maxHeap.Peek().val;
            }
        }
        return output;
    }
}
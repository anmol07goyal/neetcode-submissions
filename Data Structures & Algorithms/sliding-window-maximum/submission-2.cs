public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (k == 1)
            return nums;

        int n = nums.Length;
        int[] leftMax = new int[n];
        int[] rightMax = new int[n];
        int[] output = new int[n - k + 1];
        rightMax[n - 1] = nums[n - 1];

        for (int i = 0; i < n; i++) {
            if (i % k == 0)
                leftMax[i] = nums[i];
            else
                leftMax[i] = Math.Max(nums[i], leftMax[i - 1]);
        }

        for (int i = n - 2; i >= 0; i--) {
            if ((i + 1) % k == 0)
                rightMax[i] = nums[i];
            else
                rightMax[i] = Math.Max(nums[i], rightMax[i + 1]);
        }

        for (int i = 0; i < n - k + 1; i++) {
            output[i] = Math.Max(rightMax[i], leftMax[i + k - 1]);
        }
        return output;
    }
}
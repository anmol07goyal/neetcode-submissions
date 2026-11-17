public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] pre = new int[n];
        int[] post = new int[n];

        pre[0] = 1;
        post[n - 1] = 1;

        for (int i = 0; i < n; i++) {
            if (i > 0)
                pre[i] = nums[i - 1] * pre[i - 1];
            if (i < n - 1) {
                var idx = n - 2 - i;
                post[idx] = nums[idx + 1] * post[idx + 1];
            }
        }

        for (int i = 0; i < n; i++)
            nums[i] = pre[i] * post[i];
        
        return nums;
    }
}
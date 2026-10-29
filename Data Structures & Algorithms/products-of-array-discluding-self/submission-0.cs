public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //1,2,4,6
        //1,2,8,48
        //48,48,24,6
        int n = nums.Length;
        var prefix = new int[n];
        var suffix = new int[n];
        var res = new int[n];

        prefix[0] = nums[0];
        suffix[n-1] = nums[n-1];
        for (int i = 1; i < n; i++)
            prefix[i] = nums[i] * prefix[i-1];
        for (int i = n-2; i >= 0; i--)
            suffix[i] = nums[i] * suffix[i+1];
        
        res[0] = suffix[1];
        res[n-1] = prefix[n-2];
        for (int i = 1; i < n - 1; i++)
            res[i] = prefix[i - 1] * suffix[i + 1];
        
        return res;
    }
}

public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int l = 0, r = n - 1;
        // in case of non rotated array
        // if (nums[l] < nums[r]) {
        //     while (l<=r)
        //     {
        //         int m = (l+r)/2;
        //         if ()
        //     }
        // }

        while (l <= r) {
            int m = (l + r) / 2;
            if (nums[m] < target)
                l = m + 1;
            else if (nums[m] > target) {
                if (nums[n - 1] < target)
                    r = m - 1;
                else
                    l = m + 1;
            } else
                return m;
        }
        return -1;
    }
}
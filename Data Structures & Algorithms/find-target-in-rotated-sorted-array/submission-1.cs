public class Solution {
    public int BinaryS(int[] nums, int l, int r, int target) {
        while (l <= r) {
            int m = (l + r) / 2;
            if (nums[m] > target)
                r = m - 1;
            else if (nums[m] < target)
                l = m + 1;
            else
                return m;
        }
        return -1;
    }

    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        // in case of non rotated array
        if (nums[l] < nums[r])
            return BinaryS(nums, l, r, target);

        while (l <= r) {
            int m = (l + r) / 2;
            if (nums[m] < nums[r])
                r = m;
            else
                l = m + 1;
        }
        int minIdx = l - 1;

        if (nums[minIdx] == target)
            return minIdx;
        else
            return BinaryS(nums, 0, minIdx - 1, target);
    }
}
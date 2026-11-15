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
        int n = nums.Length;
        int l = 0, r = n - 1;
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
        Console.WriteLine("idx: " + minIdx);
        if (nums[minIdx] == target)
            return minIdx;
        else if (nums[n - 1] >= target)
            return BinaryS(nums, minIdx, n - 1, target);
        else
            return BinaryS(nums, 0, minIdx - 1, target);
    }
}
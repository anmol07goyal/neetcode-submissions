public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
            return 0;

        var hash = new HashSet<int>();
        int res = 1;
        foreach (var n in nums)
            hash.Add(n);

        foreach (var n in nums)
        {
            if (hash.Contains(n - 1)) continue;
            int max = 1;
            while (hash.Contains(n + max))
                max++;
            if (max > res)
                res = max;
        }
        return res;
    }
}
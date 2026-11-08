public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hash = new HashSet<int>();
        int res = 1;
        foreach (var n in nums)
            hash.Add(n);

        foreach (var n in nums)
        {
            if (hash.Contains(n - 1)) continue;
            int max = 1;
            int next = n + 1;
            while (hash.Contains(next))
            {
                max++;
                next++;
            }
            if (max > res)
                res = max;
        }
        return res;
    }
}
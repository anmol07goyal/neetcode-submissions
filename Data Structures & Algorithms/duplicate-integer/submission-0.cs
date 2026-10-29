public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashSet = new HashSet<int>();
        foreach(var n in nums)
        {
            if (!hashSet.Contains(n))
                hashSet.Add(n);
            else
                return true;
        }

        return false;
    }
}
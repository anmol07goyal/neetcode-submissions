public class Solution {
    public int FindMin(int[] nums) {
        //linear solution
        int min = int.MaxValue;
        foreach (var n in nums)
            min = Math.Min(min, n);
        return min;
    }
}

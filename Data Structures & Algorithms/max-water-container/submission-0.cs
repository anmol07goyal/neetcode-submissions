public class Solution {
    public int MaxArea(int[] heights) {
        int water = 0;
        int min = 0;
        if (heights.Length == 2)
            return Math.Min(heights[0], heights[1]);
        int l = 0;
        int r = heights.Length - 1;
        while(l < r)
        {
            min = Math.Min(heights[l], heights[r]);
            int store = min * (r - l);
            water = Math.Max(water, store);
            if (heights[l] == min) l++;
            else r--;
        }
        return water;
    }
}

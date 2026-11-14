public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int n = piles.Length;
        int maxPile = int.MinValue;
        foreach (var p in piles) 
            maxPile = Math.Max(maxPile, p);
        if (n == h)
            return maxPile;

        int minSpeed = maxPile;
        int l = 1;
        int r = maxPile;
        while (l <= r) {
            int m = (l + r) / 2;
            long totalHours = 0;
            foreach (var p in piles) 
                totalHours += (p + m - 1) / m;
            if (totalHours > h)
                l = m + 1;
            else {
                minSpeed = m; //cause we are now moving into left half, so any new speed will be the minimum speed for eating bananas.
                r = m - 1;
            }
        }
        return minSpeed;
    }
}

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
            int totalHours = 0;
            foreach (var p in piles) 
                totalHours += (p + m - 1) / m;
            if (totalHours > h)
                r = m - 1;
            else {
                minSpeed = Math.Min(minSpeed, m);
                l = m + 1;
            }
        }
        return minSpeed;
    }
}

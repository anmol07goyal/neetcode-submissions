public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int n = piles.Length;
        long maxPile = long.MinValue;
        foreach (var p in piles) 
            maxPile = Math.Max(maxPile, p);
        if (n == h)
            return (int)maxPile;

        long minSpeed = maxPile;
        long l = 1;
        long r = maxPile;
        while (l <= r) {
            long m = (l + r) / 2;
            long totalHours = 0;
            foreach (var p in piles) 
                totalHours += (p + m - 1) / m;
            if (totalHours > h)
                l = m + 1;
            else {
                minSpeed = Math.Min(minSpeed, m);
                r = m - 1;
            }
        }
        return (int)minSpeed;
    }
}

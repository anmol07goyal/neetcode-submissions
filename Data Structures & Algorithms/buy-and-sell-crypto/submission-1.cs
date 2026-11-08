public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int r = prices.Length - 1;
        int res = 0;
        while (l < r) {
            if (prices[l] > prices[r])
                l++;
            else
                r--;
            res = Math.Max(res, prices[r] - prices[l]);
        }
        return res;
    }
}
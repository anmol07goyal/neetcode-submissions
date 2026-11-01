public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int min = prices[0];
        int cur = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            cur = prices[i];
            if (cur < min)
                min = cur;
            int profit = cur - min;
            if (profit > maxProfit)
                maxProfit = profit;
        }
        return maxProfit;
    }
}

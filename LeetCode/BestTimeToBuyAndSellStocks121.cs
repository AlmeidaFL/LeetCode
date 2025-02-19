namespace LeetCode;

public class BestTimeToBuyAndSellStocks121
{
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length == 0 || prices.Length == 1)
        {
            return 0;
        }
        
        var gain = 0;
        var firstPrice = prices[0];

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] < firstPrice)
            {
                firstPrice = prices[i];
            }
            else
            {
                var maxProfit = Math.Max(gain, prices[i] - firstPrice);
                gain = maxProfit;
            }
        }
        
        return gain;
    }
}
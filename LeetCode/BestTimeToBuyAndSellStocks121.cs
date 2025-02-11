namespace LeetCode;

public class BestTimeToBuyAndSellStocks121
{
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length < 2)
        {
            return 0;
        }
        
        var minDay = prices[0];
        var maxDay = prices[^1];
        
        if (minDay >= maxDay && prices.Length == 2)
        {
            return 0;
        }
        if (maxDay > minDay && prices.Length == 2)
        {
            return maxDay - minDay;
        }
        
        var counterAsc = 1;
        var counterDec = prices.Length - 2;
        while (counterAsc <= counterDec)
        {
            if (prices[counterAsc] < minDay)
            {
                minDay = prices[counterAsc];
            }
            if (prices[counterDec] > maxDay)
            {
                maxDay = prices[counterDec];
            }

            counterAsc++;
            counterDec--;
        }

        if (minDay >= maxDay)
        {
            return 0;
        }
        
        return maxDay - minDay;
    }
}
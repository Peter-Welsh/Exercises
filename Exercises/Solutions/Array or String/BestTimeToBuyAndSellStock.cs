// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description
namespace Exercises.Solutions.Array_or_String;

public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        var buyDay = 0;
        var sellDay = 1;
        var maxProfit = 0;
        while (sellDay < prices.Length)
        {
            var profit = prices[sellDay] - prices[buyDay];
            if (profit < 0)
            {
                buyDay = sellDay;
            }
            sellDay++;
            maxProfit = Math.Max(profit, maxProfit);
        }
        return maxProfit;
    }
}
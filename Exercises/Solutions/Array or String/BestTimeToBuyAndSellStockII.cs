// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description
namespace Exercises.Solutions.Array_or_String;

public class BestTimeToBuyAndSellStockII
{
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var buyPrice = prices[0];
        foreach (var priceToday in prices)
        {
            var profitIfWeSellToday = priceToday - buyPrice;
            maxProfit += Math.Max(0, profitIfWeSellToday);
            buyPrice = priceToday;
        }
        return maxProfit;
    }
}
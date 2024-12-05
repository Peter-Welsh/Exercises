// https://leetcode.com/problems/candy/description
namespace Exercises.Solutions.Array_or_String;

public class CandyDistribution
{
    // More concise but less performant
    public int Candy(int[] ratings)
    {
        var candies = new int[ratings.Length];        
        Array.Fill(candies, 1);
        for (var i = 1; i < candies.Length; i++)
        {
            if (ratings[i] <= ratings[i - 1]) { continue; }
            candies[i] = candies[i - 1] + 1;
        }
        for (var i = candies.Length - 2; i >= 0; i--)
        {
            if (ratings[i] <= ratings[i + 1]) { continue; }
            candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
        }
        return candies.Sum();
    }
    
    // Less concise but more performant
    public int Candy_Ugly(int[] ratings)
    {
        if (ratings.Length == 0) { return 0; }
        var totalMinimum = 1;
        var up = 0;
        var down = 0;
        var peak = 0;
        for (var i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                up++;
                down = 0;
                peak = up;
                totalMinimum += up + 1;
                continue;
            }
            if (ratings[i] < ratings[i - 1])
            {
                up = 0;
                down++;
                totalMinimum += down;
                if (down > peak)
                {
                    totalMinimum++;
                }
                continue;
            }
            up = 0;
            down = 0;
            peak = 0;
            totalMinimum++;
        }
        return totalMinimum;
    }
}
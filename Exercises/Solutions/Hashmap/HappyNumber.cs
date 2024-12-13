// https://leetcode.com/problems/happy-number/description
namespace Exercises.Solutions.Hashmap;

public class HappyNumber
{
    /// <summary>
    /// Iterative solution 
    /// </summary>
    public bool IsHappy(int n)
    {
        while (n > 9)
        {
            var sum = 0;
            while (n > 0)
            {
                sum += n % 10 * (n % 10);
                n /= 10;
            }
            n = sum;
        }
        return n is 1 or 7;
    }

    /// <summary>
    /// Recursive solution 
    /// </summary>
    public bool IsHappy_Recursive(int n)
    {
        if (n < 10) { return n is 1 or 7; }
        var sum = 0;
        while (n > 0)
        {
            sum += n % 10 * (n % 10);
            n /= 10;
        }
        return IsHappy(sum);
    }
}
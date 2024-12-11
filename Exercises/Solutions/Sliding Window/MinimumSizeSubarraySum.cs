// https://leetcode.com/problems/minimum-size-subarray-sum/description
namespace Exercises.Solutions.Sliding_Window;

public class MinimumSizeSubarraySum
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        var minLength = int.MaxValue;
        for (int l = 0, r = 0, sum = nums[0]; l < nums.Length;)
        {
            if (sum >= target)
            {
                minLength = Math.Min(r - l + 1, minLength);
                sum -= nums[l];
                l++;
                continue;
            }
            r++;
            if (r == nums.Length) { break; }
            sum += nums[r];
        }
        return minLength == int.MaxValue ? 0 : minLength;
    }
}
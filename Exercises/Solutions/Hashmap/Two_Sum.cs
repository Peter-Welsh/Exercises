// https://leetcode.com/problems/two-sum/description
namespace Exercises.Solutions.Hashmap;

public class Two_Sum
{
    /// <summary>
    /// Fast solution - O(n) 
    /// </summary>
    public int[] TwoSum(int[] nums, int target)
    {
        var indexesMap = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (indexesMap.TryGetValue(target - nums[i], out var index))
            {
                return [index, i];
            }
            indexesMap[nums[i]] = i;
        }
        return [];
    }
    
    /// <summary>
    /// Slow solution - O(n^2) 
    /// </summary>
    public int[] TwoSum_Slow(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
                if (nums[j] + nums[j - 1] == target)
                {
                    return [j, j-1];
                }
            }
        }
        return [];
    }
}
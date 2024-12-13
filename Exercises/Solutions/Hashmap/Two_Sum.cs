// https://leetcode.com/problems/two-sum/description
namespace Exercises.Solutions.Hashmap;

public class Two_Sum
{
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
}
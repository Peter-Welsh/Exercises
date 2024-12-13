// https://leetcode.com/problems/longest-consecutive-sequence/description
namespace Exercises.Solutions.Hashmap;

public class LongestConsecutiveSequence
{
    /// <summary>
    /// Solution using Sort, without extra memory 
    /// </summary>
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) { return 0; }
        Array.Sort(nums);
        var maxLength = 1;
        var length = 1;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1] - 1)
            {
                length++;
                maxLength = Math.Max(maxLength, length);
            }
            else if (nums[i] != nums[i + 1])
            {
                length = 1;
            }
        }
        return maxLength;
    }
    
    /// <summary>
    /// Solution without Sort, using Dictionary
    /// </summary>
    public int LongestConsecutive_NoSort(int[] nums)
    {
        var map = new Dictionary<int, int>();
        var longestLength = 0;
        foreach (var num in nums)
        {
            if (map.ContainsKey(num)) { continue; }
            var prevNum = map.GetValueOrDefault(num - 1);
            var nextNum = map.GetValueOrDefault(num + 1);
            var length = prevNum + nextNum + 1;
            map[num] = length;
            map[num - prevNum] = length;
            map[num + nextNum] = length;
            longestLength = Math.Max(length, longestLength);
        }
        return longestLength;
    }
    
    /// <summary>
    /// Solution without Sort, using HashSet
    /// </summary>
    /// <remarks>Times out for one test case (#76)</remarks>
    public int LongestConsecutive_HashSet(int[] nums)
    {
        var numSet = new HashSet<int>(nums);
        var longestLength = 0;
        foreach (var num in nums)
        {
            if (numSet.Contains(num - 1))
            {
                continue;
            }
            var length = 1;
            while (numSet.Contains(num + length))
            {
                length++;
            }
            longestLength = Math.Max(length, longestLength);
        }
        return longestLength;
    }
}
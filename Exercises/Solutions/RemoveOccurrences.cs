// https://leetcode.com/problems/remove-element/description/
namespace Exercises.Solutions;

public class RemoveOccurrences
{
    public int RemoveElement(int[] nums, int val)
    {
        var j = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val) { continue; }
            nums[j] = nums[i];
            j++;
        }
        return j;
    }
}
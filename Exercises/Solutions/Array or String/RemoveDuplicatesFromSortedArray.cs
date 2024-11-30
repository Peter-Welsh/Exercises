// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description

namespace Exercises.Solutions.Array_or_String;

public class RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        var j = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) { continue; }
            nums[j] = nums[i];
            j++;
        }
        return j;
    }
}
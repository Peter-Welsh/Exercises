// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description
namespace Exercises.Solutions.Array_or_String;

public class RemoveDuplicatesFromSortedArrayII
{
    public int RemoveDuplicates(int[] nums)
    {
        var j = 2;
        if (nums.Length < 3) { return nums.Length; }
        for (var i = 2; i < nums.Length; i++)
        {
            if (nums[i] == nums[j - 2]) { continue; }
            nums[j] = nums[i];
            j++;
        }
        return j; 
    }
}
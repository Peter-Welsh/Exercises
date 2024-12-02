// https://leetcode.com/problems/majority-element/description
namespace Exercises.Solutions.Array_or_String;

public class GetMajorityElement
{
    public int MajorityElement(int[] nums)
    {
        var count = 0;
        var candidate = 0;
        foreach (var num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }
            var offset = num == candidate ? 1 : -1;
            count += offset;
        }
        return candidate;
    }
}
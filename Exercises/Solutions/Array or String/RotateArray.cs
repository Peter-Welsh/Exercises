// https://leetcode.com/problems/rotate-array/description
namespace Exercises.Solutions.Array_or_String;

public class RotateArray
{
    public void Rotate(int[] nums, int k)
    {
        var pivot = k % nums.Length;
        Array.Reverse(nums);
        Array.Reverse(nums, 0, pivot);
        Array.Reverse(nums, pivot, nums.Length - pivot);
    }
}
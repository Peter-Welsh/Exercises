// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description
namespace Exercises.Solutions.Two_Pointers;

public class TwoSumII_InputArrayIsSorted
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int l = 0, r = numbers.Length - 1; l < r;)
        {
            var sum = numbers[l] + numbers[r];
            if (sum > target)
            {
                r--;
                continue;
            }
            if (sum < target)
            {
                l++;
                continue;
            }
            return [l + 1, r + 1];
        }
        return [];
    }
}
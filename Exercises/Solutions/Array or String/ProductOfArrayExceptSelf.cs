// https://leetcode.com/problems/product-of-array-except-self/description
namespace Exercises.Solutions.Array_or_String;

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        var leftProduct = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = leftProduct;
            leftProduct *= nums[i];
        }
        var rightProduct = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= rightProduct;
            rightProduct *= nums[i];
        }
        return result;
    }
}
// https://leetcode.com/problems/contains-duplicate-ii/description
namespace Exercises.Solutions.Hashmap;

public class ContainsDuplicateII
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var nearbyNumbers = new HashSet<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (i > k)
            {
                nearbyNumbers.Remove(nums[i - k - 1]);
            }
            if (!nearbyNumbers.Add(nums[i]))
            {
                return true;
            }
        }
        return false;
    }
}
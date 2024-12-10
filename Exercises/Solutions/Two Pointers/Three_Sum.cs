// https://leetcode.com/problems/3sum/description
namespace Exercises.Solutions.Two_Pointers;

public class Three_Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var triplets = new List<IList<int>>();
        Array.Sort(nums);
        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] > 0) { break; }
            if (i > 0 && nums[i] == nums[i - 1]) { continue; }
            var l = i + 1;
            var r = nums.Length - 1;
            while (l < r)
            {
                var sum = nums[i] + nums[l] + nums[r];
                switch (sum)
                {
                    case > 0:
                        r--;
                        continue;
                    case < 0:
                        l++;
                        continue;
                }
                var triplet = new List<int> { nums[i], nums[l], nums[r] };
                triplets.Add(triplet);
                l++;
                r--;
                while (l < r && nums[l - 1] == nums[l])
                {
                    l++;
                }
            }
        }
        return triplets;
    }
}
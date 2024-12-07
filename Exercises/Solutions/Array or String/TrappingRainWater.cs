// https://leetcode.com/problems/trapping-rain-water/description
namespace Exercises.Solutions.Array_or_String;

public class TrappingRainWater
{
    public int Trap(int[] height)
    {
        if (height.Length == 0) { return 0; }
        var l = 0;
        var r = height.Length - 1;
        var leftMax = height[l];
        var rightMax = height[r];
        var totalUnitsOfWaterTrapped = 0;
        while (l < r)
        {
            if (leftMax < rightMax)
            {
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                totalUnitsOfWaterTrapped += leftMax - height[l];
                continue;
            }
            r--;
            rightMax = Math.Max(rightMax, height[r]);
            totalUnitsOfWaterTrapped += rightMax - height[r];
        }
        return totalUnitsOfWaterTrapped;
    }
}
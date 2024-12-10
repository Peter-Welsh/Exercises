// https://leetcode.com/problems/container-with-most-water/description
namespace Exercises.Solutions.Two_Pointers;

public class ContainerWithMostWater
{
    public int MaxArea(int[] heights)
    {
        var maxArea = 0;
        for (int l = 0, r = heights.Length - 1; l < r;)
        {
            var width = r - l;
            var height = Math.Min(heights[l], heights[r]);
            var area = width * height;
            maxArea = Math.Max(area, maxArea);
            if (heights[l] > heights[r])
            {
                r--;
                continue;
            }
            l++;
        }
        return maxArea;
    }
}
// https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/description
namespace Exercises.Solutions.Intervals;

public class MinimumNumberOfArrowsToBurstBalloons
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (a, b) => a[1] < b[1] ? -1 : 1);
        var arrowPos = points[0][1];
        var numShots = 1;
        for (var i = 1; i < points.Length; i++)
        {
            if (arrowPos >= points[i][0]) { continue; }
            numShots++;
            arrowPos = points[i][1];
        }
        return numShots;
    }
}
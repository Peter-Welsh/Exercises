// https://leetcode.com/problems/insert-interval/description
namespace Exercises.Solutions.Intervals;

public class InsertInterval
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var newIntervals = new List<int[]>();
        var inserted = false;
        foreach (var interval in intervals)
        {
            var min = interval[0];
            var max = interval[1];
            if (newInterval[0] > max || newInterval[1] < min)
            {
                if (newInterval[1] < min && !inserted)
                {
                    newIntervals.Add(newInterval);
                    inserted = true;
                }
                newIntervals.Add(interval);
                continue;
            }
            newInterval[0] = Math.Min(min, newInterval[0]);
            newInterval[1] = Math.Max(max, newInterval[1]);
        }
        if (!inserted) { newIntervals.Add(newInterval); }
        return newIntervals.ToArray();
    }
}
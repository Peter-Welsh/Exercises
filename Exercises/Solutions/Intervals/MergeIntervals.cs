// https://leetcode.com/problems/merge-intervals/description
namespace Exercises.Solutions.Intervals;

public class MergeIntervals
{
    #region Solution 1
    /// <summary>
    /// Optimized solution - O(n)
    /// </summary>
    public int[][] Merge(int[][] intervals)
    {
        var range = GetRange(intervals, out var min);
        int start = 0, end = 0;
        var result = new List<int[]>();
        for (var i = 0; i < range.Length; i++)
        {
            if (range[i] == 0) { continue; }
            if (i > end)
            {
                result.Add([start + min, end + min]);
                start = i;
                end = range[i];
                continue;
            }
            end = Math.Max(range[i], end);
        }
        result.Add([start + min, end + min]);
        return result.ToArray();
    }

    private static int[] GetRange(int[][] intervals, out int min)
    {
        min = int.MaxValue;
        var max = int.MinValue;
        foreach (var interval in intervals)
        {
            min = Math.Min(min, interval[0]);
            max = Math.Max(max, interval[0]);
        }
        var range = new int[max - min + 1];
        foreach (var interval in intervals)
        {
            range[interval[0] - min] = Math.Max(interval[1] - min, range[interval[0] - min]);
        }
        return range;
    }
    #endregion
    
    /// <summary>
    /// One-liner - O(sort) 
    /// </summary>
    public int[][] Merge_OneLiner(int[][] intervals) =>
        intervals
            .OrderBy(i => i[0])
            .Aggregate(new List<int[]>(), (res, cur) =>
            {
                if (res.Count == 0 || res[^1][1] < cur[0])
                    res.Add(cur);
                else
                    res[^1][1] = Math.Max(res[^1][1], cur[1]);
                return res;
            })
            .ToArray();
    
    /// <summary>
    /// Sane solution - O(sort) 
    /// </summary>
    public int[][] Merge_Sane(int[][] intervals)
    {
        if (intervals.Length <= 1) { return intervals; }
        Array.Sort(intervals, (x, y) => x[0] - y[0]);
        var ranges = new List<int[]>();
        var range = intervals[0];
        foreach (var interval in intervals)
        {
            if (interval[0] > range[1])
            {
                ranges.Add(range);
                range = interval;
                continue;
            }
            range[1] = Math.Max(interval[1], range[1]);
        }
        ranges.Add(range);
        return ranges.ToArray();
    }
}
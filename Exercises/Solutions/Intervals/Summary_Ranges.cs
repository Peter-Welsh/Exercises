// https://leetcode.com/problems/summary-ranges/description
namespace Exercises.Solutions.Intervals;

public class Summary_Ranges
{
    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0) { return []; }
        var ranges = new List<string>();
        for (int start = 0, end = 0; end < nums.Length; end++)
        {
            if (end + 1 < nums.Length && nums[end] + 1 == nums[end + 1]) { continue; }
            var range = start == end ? $"{nums[start]}" : $"{nums[start]}->{nums[end]}";
            ranges.Add(range);
            start = end + 1;
        }
        return ranges;
    }
}
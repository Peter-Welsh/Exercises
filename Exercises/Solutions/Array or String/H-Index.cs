//  https://leetcode.com/problems/h-index/description
namespace Exercises.Solutions.Array_or_String;

public class H_Index
{
    public int HIndex(int[] citations)
    {
        var counts = new int[citations.Length + 2];
        for (var i = citations.Length - 1; i >= 0; i--)
        {
            var j = Math.Min(citations[i], citations.Length);
            counts[j]++;    
        }
        var hIndex = citations.Length;
        while (hIndex > 0)
        {
            counts[hIndex] += counts[hIndex + 1];
            if (counts[hIndex] >= hIndex) { break; }
            hIndex--;
        }
        return hIndex;
    }
}
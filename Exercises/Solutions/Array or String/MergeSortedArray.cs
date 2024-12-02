// https://leetcode.com/problems/merge-sorted-array/description/
namespace Exercises.Solutions.Array_or_String;

public class MergeSortedArray
{
    // Understandable and concise solution (for use when performance is not the top priority)
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        Array.Copy(nums2, 0, nums1, m, nums2.Length);
        Array.Sort(nums1);
    }
    
    // Ugly solution -- use only when performance is the top priority
    public void Merge_Ugly(int[] nums1, int m, int[] nums2, int n)
    {
        var i = m - 1;
        var j = n - 1;
        var k = m + n - 1;
        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }
    }
}
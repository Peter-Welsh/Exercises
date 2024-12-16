// https://leetcode.com/problems/reverse-linked-list-ii/description
namespace Exercises.Solutions.Linked_List;

public class ReverseLinkedListII
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        var dummy = new ListNode
        {
            next = head
        };
        var prev = dummy;
        for (var i = 0; i < left - 1; i++)
        {
            prev = prev!.next;
        }
        var start = prev!.next;
        var curr = start!.next;
        for (var i = 0; i < right - left; i++)
        {
            start.next = curr!.next;
            curr.next = prev.next;
            prev.next = curr;
            curr = start.next;
        }
        return dummy.next;
    }
}
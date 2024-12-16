// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/description
namespace Exercises.Solutions.Linked_List;

public class RemoveDuplicatesFromSortedListII
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        if (head == null) { return null; }
        var dummy = new ListNode
        {
            next = head
        };
        var prev = dummy;
        var curr = head;
        while (curr is not null)
        {
            while (curr.next is not null && curr.val == curr.next.val)
            {
                curr = curr.next;
            }
            if (prev.next == curr)
            {
                prev = prev.next;
            }
            else
            {
                prev.next = curr.next;
            }
            curr = curr.next;
        }
        return dummy.next;
    }
}
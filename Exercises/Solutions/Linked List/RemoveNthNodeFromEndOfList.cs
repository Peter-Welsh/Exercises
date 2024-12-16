// https://leetcode.com/problems/remove-nth-node-from-end-of-list/description
namespace Exercises.Solutions.Linked_List;

public class RemoveNthNodeFromEndOfList
{
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(0, head);
        var left = dummy;
        var right = head;
        while (n > 0)
        {
            right = right.next!;
            n--;
        }
        while (right is not null)
        {
            right = right.next;
            left = left.next!;
        }
        left.next = left.next!.next;
        return dummy.next;
    }
}
// https://leetcode.com/problems/rotate-list/description
namespace Exercises.Solutions.Linked_List;

public class RotateList
{
    public ListNode? RotateRight(ListNode? head, int k)
    {
        if (head == null || k == 0) { return head; }
        var p = head;
        var length = 1;
        while (p.next is not null)
        {
            p = p.next;
            length++;
        }
        p.next = head;
        k %= length;
        for (var i = 0; i < length - k; i++)
        {
            p = p!.next;
        }
        head = p!.next;
        p.next = null;
        return head;
    }
}
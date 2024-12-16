// https://leetcode.com/problems/reverse-nodes-in-k-group/description
namespace Exercises.Solutions.Linked_List;

public class ReverseNodesInKGroup
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        var curr = head;
        var count = 0;
        while (curr != null && count != k)
        {
            curr = curr.next;
            count++;
        }
        if (count != k) { return head; }
        curr = ReverseKGroup(curr!, k);
        while (count-- > 0)
        {
            var tmp = head.next;
            head.next = curr;
            curr = head;
            head = tmp!;
        }
        head = curr;
        return head;
    }
}
// https://leetcode.com/problems/partition-list/description
namespace Exercises.Solutions.Linked_List;

public class PartitionList
{
    public ListNode? Partition(ListNode? head, int x)
    {
        var smallerHead = new ListNode();
        var biggerHead = new ListNode();
        var smaller = smallerHead;
        var bigger = biggerHead;
        while (head is not null)
        {
            if (head.val < x)
            {
                smaller = smaller.next = head;
            }
            else
            {
                bigger = bigger.next = head;
            }
            head = head.next;
        }
        smaller.next = biggerHead.next;
        bigger.next = null;
        return smallerHead.next;
    }
}
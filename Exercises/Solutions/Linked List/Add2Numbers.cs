// https://leetcode.com/problems/add-two-numbers/description
namespace Exercises.Solutions.Linked_List;

public class Add2Numbers
{
    /// <summary>
    /// Iterative solution
    /// </summary>
    public ListNode? AddTwoNumbers(ListNode l1, ListNode? l2)
    {
        var carry = 0;
        var dummy = new ListNode();
        var p = dummy;
        while (l1 != null || l2 != null || carry != 0)
        {
            if (l1 != null)
            {
                carry += l1.val;
                l1 = l1.next!;
            }
            if (l2 != null)
            {
                carry += l2.val;
                l2 = l2.next;
            }
            p.next = new ListNode(carry % 10);
            carry /= 10;
            p = p.next;
        }
        return dummy.next;
    }
    
    /// <summary>
    /// Recursive solution
    /// </summary>
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2, int carry = 0)
    {
        if (l1 is null && l2 is null && carry is 0) { return null; }
        var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
        var node = new ListNode(sum % 10);
        carry = sum / 10;
        node.next = AddTwoNumbers(l1?.next, l2?.next, carry);
        return node;
    }
}
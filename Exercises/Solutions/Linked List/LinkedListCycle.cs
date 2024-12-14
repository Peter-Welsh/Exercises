// https://leetcode.com/problems/linked-list-cycle/description
namespace Exercises.Solutions.Linked_List;

public class LinkedListCycle
{
    /// <summary>
    /// Solution using O(1) extra memory
    /// </summary>
    public bool HasCycle(ListNode head)
    {
        var slow = head;
        var fast = head;
        while (fast?.next is not null)
        {
            slow = slow!.next;
            fast = fast.next.next?.next;
            if (slow == fast) { return true; }
        }
        return false;
    }
    
    /// <summary>
    /// Solution using O(n) extra memory 
    /// </summary>
    public bool HasCycle_HashSet(ListNode head)
    {
        var visitedNodes = new HashSet<ListNode>();
        var currentNode = head;
        while (currentNode != null)
        {
            if (!visitedNodes.Add(currentNode)) { return true; }
            currentNode = currentNode.next;
        }
        return false;
    }
}

public abstract class ListNode(int x)
{
    public int val = x;
    public readonly ListNode? next = null;
}

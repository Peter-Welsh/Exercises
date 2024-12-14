// https://leetcode.com/problems/min-stack/description
namespace Exercises.Solutions.Stack;

public class Min_Stack
{
    public class MinStack
    {
        private Node head = new();

        public void Push(int val)
        {
            head = head.Next == null
                ? new Node(val, val, head)
                : new Node(val, Math.Min(val, head.Min), head);
        }

        public void Pop() => head = head.Next!;

        public int Top() => head.Val;

        public int GetMin() => head.Min;
    }

    public class Node
    {
        public readonly Node? Next;
        public readonly int Val;
        public readonly int Min;
        public Node() {}
        public Node(int val, int min, Node next)
        {
            Next = next;
            Val = val;
            Min = min;
        }
    }
}
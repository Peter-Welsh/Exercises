// https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/description
namespace Exercises.Solutions.Binary_Tree_General;

public class PopulatingNextRightPointersInEachNodeII
{
    public class Solution
    {
        public Node? Connect(Node? root)
        {
            if (root is null) { return root; }
            Queue<Node> nodes = new();
            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                var count = nodes.Count;
                Node? previous = null;
                for (var i = 0; i < count; i++)
                {
                    var current = nodes.Dequeue();
                    if (current.right is not null)
                        nodes.Enqueue(current.right);
                    if (current.left is not null)
                        nodes.Enqueue(current.left);
                    current.next = previous;
                    previous = current;
                }
            }
            return root;
        }
    }
}

public class Node
{
    public int val;
    public readonly Node? left;
    public readonly Node? right;
    public Node? next;

    public Node() {}

    public Node(int val)
    {
        this.val = val;
    }

    public Node(int val, Node left, Node right, Node next)
    {
        this.val = val;
        this.left = left;
        this.right = right;
        this.next = next;
    }
}
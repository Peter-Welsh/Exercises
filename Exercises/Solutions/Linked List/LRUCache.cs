// https://leetcode.com/problems/lru-cache/description
namespace Exercises.Solutions.Linked_List;

public class LRUCache_Solution
{
    public class ListNode(int value = 0, int key = 0, ListNode? next = null, ListNode? prev = null)
    {
        public int value = value;
        public readonly int key = key;
        public ListNode? next = next;
        public ListNode? prev = prev;

        public static void AddNode(ListNode node, ListNode head)
        {
            node.next = head.next;
            head.next!.prev = node;
            head.next = node;
            node.prev = head;
        }

        public static void DeleteNode(ListNode node)
        {
            node.prev!.next = node.next;
            node.next!.prev = node.prev;
            node.next = null;
            node.prev = null;
        }
    }

    public class LRUCache
    {
        private int size;
        private readonly int capacity;
        private readonly ListNode head;
        private readonly ListNode last;
        private readonly ListNode?[] map;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            head = new ListNode(-1, -1);
            map = new ListNode[10001];
            last = new ListNode(-1, -1);
            head.next = last;
            last.prev = head;
            size = 0;
        }

        public int Get(int key)
        {
            if (map[key] is null) { return -1; }
            var node = map[key];
            ListNode.DeleteNode(node!);
            ListNode.AddNode(node!, head);
            return node!.value;
        }

        public void Put(int key, int value)
        {
            ListNode node;
            if (map[key] is null)
            {
                node = new ListNode(value, key);
                ListNode.AddNode(node, head);
                size++;
                map[key] = node;
            }
            else
            {
                node = map[key]!;
                node.value = value;
                ListNode.DeleteNode(node);
                ListNode.AddNode(node, head);
            }
            if (size <= capacity) { return; }
            map[last.prev!.key] = null;
            ListNode.DeleteNode(last.prev);
            size--;
        }
    }
}
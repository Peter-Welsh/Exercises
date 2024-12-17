// https://leetcode.com/problems/same-tree/description
namespace Exercises.Solutions.Binary_Tree_General;

public abstract class SameTree
{
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if (p is null && q is null) { return true; }
        if (p is null && q is not null) { return false; }
        if (p is not null && q is null) { return false; }
        return p!.val == q!.val
               && IsSameTree(p.left, q.left)
               && IsSameTree(p.right, q.right);
    }
}
public abstract class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public readonly int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}
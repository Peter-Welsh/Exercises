// https://leetcode.com/problems/symmetric-tree/descriptiom
namespace Exercises.Solutions.Binary_Tree_General;

public class SymmetricTree
{
    public bool IsSymmetric(TreeNode root) => IsSymmetric(root.left, root.right);

    private static bool IsSymmetric(TreeNode? p, TreeNode? q)
    {
        if (p is null || q is null)
        {
            return p is null && q is null;
        }
        return p.val == q.val
               && IsSymmetric(p.left, q.right)
               && IsSymmetric(p.right, q.left);
    }
}
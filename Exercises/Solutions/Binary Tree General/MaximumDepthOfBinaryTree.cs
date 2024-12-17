// https://leetcode.com/problems/maximum-depth-of-binary-tree/description
namespace Exercises.Solutions.Binary_Tree_General;

public class MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode? root)
    {
        if (root is null) { return 0; }
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
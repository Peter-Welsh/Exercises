// https://leetcode.com/problems/invert-binary-tree/description
namespace Exercises.Solutions.Binary_Tree_General;

public class InvertBinaryTree
{
    public TreeNode? InvertTree(TreeNode? root)
    {
        if (root is null) { return root; }
        (root.left, root.right) = (root.right, root.left);
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}
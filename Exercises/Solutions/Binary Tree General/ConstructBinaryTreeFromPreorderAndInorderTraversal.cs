// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/description
namespace Exercises.Solutions.Binary_Tree_General;

public class ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    /// <summary>
    /// Iterative solution 
    /// </summary>
    public TreeNode? BuildTree_Iterative(int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0 || inorder.Length == 0) { return default; }
        var root = new TreeNode(preorder[0]);
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        var inorderIndex = 0;
        for (var i = 1; i < preorder.Length; i++)
        {
            var currentVal = preorder[i];
            var node = stack.Peek();
            if (node.val != inorder[inorderIndex])
            {
                node.left = new TreeNode(currentVal);
                stack.Push(node.left);
                continue;
            }
            while (stack.Count > 0 && stack.Peek().val == inorder[inorderIndex])
            {
                node = stack.Pop();
                inorderIndex++;
            }
            node.right = new TreeNode(currentVal);
            stack.Push(node.right);
        }
        return root;
    }
    
    /// <summary>
    /// Recursive solution
    /// </summary>
    public TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0 || inorder.Length == 0) { return default; }
        var mid = Array.IndexOf(inorder, preorder[0]);
        var root = new TreeNode(preorder[0])
        {
            left = BuildTree(preorder[1..(mid+1)], inorder[..mid]),
            right = BuildTree(preorder[(mid+1)..], inorder[(mid+1)..])
        };
        return root;
    }
}
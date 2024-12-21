// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/description
namespace Exercises.Solutions.Binary_Tree_General;

public class ConstructBinaryTreeFromInorderAndPostorderTraversal
{
    /// <summary>
    /// Iterative solution 
    /// </summary>
    public TreeNode? BuildTree_Iterative(int[] inorder, int[] postorder)
    {
        if (inorder.Length == 0 || postorder.Length == 0)
            return default;
        
        var postIndex = postorder.Length - 1;
        var inIndex = inorder.Length - 1;
        var root = new TreeNode(postorder[postIndex]);
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        postIndex--;
        while (postIndex >= 0)
        {
            var current = stack.Peek();
            if (current.val != inorder[inIndex])
            {
                current.right = new TreeNode(postorder[postIndex]);
                stack.Push(current.right);
                postIndex--;
                continue;
            }
            while (stack.Count > 0 && stack.Peek().val == inorder[inIndex])
            {
                current = stack.Pop();
                inIndex--;
            }
            current.left = new TreeNode(postorder[postIndex]);
            stack.Push(current.left);
            postIndex--;
        }
        return root;
    }
    
    #region Solution 2
    /// <summary>
    /// Recursive solution
    /// </summary>
    public TreeNode? BuildTree(int[] inorder, int[] postorder)
    {
        var postorderIndex = postorder.Length - 1;
        return Build(inorder, postorder, ref postorderIndex, 0, inorder.Length - 1);
    }

    private static TreeNode? Build(int[] inorder, int[] postorder, ref int postorderIndex, int left, int right)
    {
        if (left > right) { return default; }
        var rootValue = postorder[postorderIndex--];
        var inorderIndex = Array.IndexOf(inorder, rootValue, left, right - left + 1);
        var root = new TreeNode(rootValue)
        {
            right = Build(inorder, postorder, ref postorderIndex, inorderIndex + 1, right),
            left = Build(inorder, postorder, ref postorderIndex, left, inorderIndex - 1)
        };
        return root;
    }
    #endregion
}
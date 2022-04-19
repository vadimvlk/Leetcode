namespace Leetcode.Solution.Algorithms;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

/// <summary>
///  https://leetcode.com/problems/recover-binary-search-tree/
/// </summary>
public class RecoverBinarySearchTree
{
    // You are given the root of a binary search tree (BST), where the values of exactly two nodes of the tree were swapped by mistake. Recover the tree without changing its structure.
    // Input: root = [1,3,null,null,2]
    // Output: [3,1,null,null,2]
    // Explanation: 3 cannot be a left child of 1 because 3 > 1. Swapping 1 and 3 makes the BST valid.


    public void RecoverTree(TreeNode root)
    {
        {
            TreeNode first = null;
            TreeNode second = null;
            TreeNode prev = null;
            InOrder(root, ref first, ref second, ref prev);
            int temp = first.val;
            first.val = second.val;
            second.val = temp;
        }
    }

    void InOrder(TreeNode root, ref TreeNode first, ref TreeNode second, ref TreeNode prev)
    {
        if (root == null)
            return;
        InOrder(root.left, ref first, ref second, ref prev);

        if (prev != null && root.val < prev.val)
        {
            if (first == null) first = prev;
            second = root;
        }

        prev = root;
        InOrder(root.right, ref first, ref second, ref prev);
    }
}
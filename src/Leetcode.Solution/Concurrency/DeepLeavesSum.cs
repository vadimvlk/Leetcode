
// Given the root of a binary tree, return the sum of values of its deepest leaves.
//  
//
//     Example 1:
//
//
// Input: root = [1,2,3,4,5,null,6,7,null,null,null,null,8]
// Output: 15
// Example 2:
//
// Input: root = [6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]
// Output: 19
//  
//
// Constraints:
//
// The number of nodes in the tree is in the range [1, 104].
// 1 <= Node.val <= 100

namespace Leetcode.Solution.Concurrency;


  // Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }

public class DeepLeavesSum
{
    int _maxLevel = -1;
    int _result = 0;
    public int DeepestLeavesSum(TreeNode root) {        
        DeepestLeavesSumRec(root, 0);
        return _result;
    }
    
    public void DeepestLeavesSumRec(TreeNode root, int level) {
        if (level > _maxLevel) {
            _result = 0;
            _maxLevel = level;
        }
        if (level == _maxLevel) _result += root.val;
        if (root.left != null) DeepestLeavesSumRec(root.left, level + 1);
        if (root.right != null) DeepestLeavesSumRec(root.right, level + 1);
    }
    
}
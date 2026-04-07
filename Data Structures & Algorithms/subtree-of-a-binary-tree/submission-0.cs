/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null) return false;

        if(Same(root,subRoot)) return true;

        return IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);
    }

    public bool Same(TreeNode root,TreeNode subRoot){
        if(root==null  && subRoot == null) return true;

        if(root==null || subRoot ==null || root.val != subRoot.val) return false;

        return Same(root.left,subRoot.left) && Same(root.right,subRoot.right);
    }
}

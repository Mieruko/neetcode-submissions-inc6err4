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
    public List<int> res = new List<int>();
    public List<int> RightSideView(TreeNode root) {
        Check(root, 0);
        return res;
    }

    public void Check(TreeNode root, int def){
        if(root == null) return;

        if(res.Count == def){
            res.Add(root.val);
        }

        Check(root.right, def + 1);
        Check(root.left, def + 1 );
    }
}

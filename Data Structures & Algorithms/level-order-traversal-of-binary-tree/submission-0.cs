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
     List<List<int>> res = new List<List<int>>();
    public List<List<int>> LevelOrder(TreeNode root) {
        Order(root,0);
        return res;
    }

    public void Order(TreeNode root, int num){
        if(root== null) return ;

        if(res.Count == num){
            res.Add(new List<int>());
        }

        res[num].Add(root.val);
        Order(root.left, num+1);
        Order(root.right,num+1);
    }
}

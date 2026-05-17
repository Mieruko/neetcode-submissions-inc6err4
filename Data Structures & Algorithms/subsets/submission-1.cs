public class Solution {
    List<List<int>> res;
    public List<List<int>> Subsets(int[] nums) {
        res = new List<List<int>>();
        dfs(0,nums,new List<int>());
        return res;
    }

    public void dfs(int i , int[] nums, List<int> cur){
        if(i>=nums.Length){
            res.Add(new List<int> (cur));
            return;
        }

        cur.Add(nums[i]);
        dfs(i+1 , nums,cur);
        cur.RemoveAt(cur.Count -1);
        dfs(i+1,nums,cur);
    }
}

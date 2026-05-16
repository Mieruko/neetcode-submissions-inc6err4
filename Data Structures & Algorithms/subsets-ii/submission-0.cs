public class Solution {
    List<List<int>> res;
    public List<List<int>> SubsetsWithDup(int[] nums) {
        res = new List<List<int>>();
        Array.Sort(nums);
        dfs(0, new List<int>(),nums);
        return res;
    }

    public void dfs(int i , List<int> cur, int[] nums){
        res.Add(new List<int>(cur));
        for(int j=i;j<nums.Length;j++){
            if(j>i && nums[j] == nums[j-1]){
                continue;
            }
            cur.Add(nums[j]);
            dfs(j+1,cur,nums);
            cur.RemoveAt(cur.Count-1);
        }
    }
}
public class Solution {
    List<List<int>> res;
    public List<List<int>> CombinationSum2(int[] nums, int target) {
        res = new List<List<int>>();
        Array.Sort(nums); 
        dfs(0,0,target,nums,new List<int>(),res);
        return res;
    }

    public void dfs(int index,int sum,int target,int[] nums,List<int> cur,List<List<int>> res){
        if(sum == target){
            res.Add(new List<int>(cur));
            return;
        }

        for (int i = index; i < nums.Length; i++) {
            if (sum + nums[i] > target) break;


            if (i > index && nums[i] == nums[i - 1]) continue;

            cur.Add(nums[i]);
            dfs(i + 1, sum + nums[i], target, nums, cur, res);
            cur.RemoveAt(cur.Count - 1);
    }
    }
}

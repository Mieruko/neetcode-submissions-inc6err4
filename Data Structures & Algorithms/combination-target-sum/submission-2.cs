public class Solution {
    List<List<int>> res;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        res = new List<List<int>>();
        Array.Sort(nums);
        dfs(0,0,target,nums,new List<int>());
        return res;
    }

    public void dfs(int index, int sum, int target, int[] nums,List<int> cur){
        if(sum == target){
            res.Add(new List<int>(cur));
            return;
        }
        
        for(int i=index;i<nums.Length;i++){
            if(nums[i] + sum > target){
                return;
            }

            cur.Add(nums[i]);
            dfs(i,sum+nums[i],target,nums,cur);
            cur.RemoveAt(cur.Count-1);
        }
    }
}

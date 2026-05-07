public class Solution {
    List<List<int>> res;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        res = new List<List<int>>();
        Array.Sort(nums);
        backtracking(nums,0,0,target, new List<int>());
        return res;
    }

    public void backtracking(int[] nums,int index,int sum,int target , List<int> curr){
        if(sum == target){
            res.Add(new List<int>(curr));
            return;
        }

        for(int i=index;i<nums.Length;i++){
            if(nums[i] + sum > target){
                return;
            }
            curr.Add(nums[i]);
            backtracking(nums,i,sum + nums[i],target,curr);
            curr.RemoveAt(curr.Count-1);
        }
    }
}

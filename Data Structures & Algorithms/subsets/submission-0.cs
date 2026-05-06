public class Solution {
    public List<List<int>> Subsets(int[] nums) {
      List<List<int>> res = new List<List<int>>();
        List<int> curr = new List<int>();
        backtracking(nums,0,curr,res);
        return res;
    }

    public void backtracking(int[] nums,int index, List<int> curr, List<List<int>> res)
    {
        if(index == nums.Length){
            res.Add(new List<int>(curr));
            return;
        }

        curr.Add(nums[index]);
        backtracking(nums,index + 1,curr,res);

        curr.RemoveAt(curr.Count -1);
        backtracking(nums,index + 1,curr,res);
    }
}

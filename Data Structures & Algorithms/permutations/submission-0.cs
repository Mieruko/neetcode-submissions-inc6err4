public class Solution {
    List<List<int>> res;
    bool[] check;
    public List<List<int>> Permute(int[] nums) {
        res = new List<List<int>>();
        check = new bool[nums.Length];
        dfs(nums,new List<int>());
        return res;
    }

    public void dfs(int[] nums, List<int> cur){
        if(cur.Count == nums.Length){
            res.Add(new List<int>(cur));
            return;
        }

        for(int i=0;i<nums.Length;i++){
            if(check[i]) continue;

            check[i] = true;
            cur.Add(nums[i]);
            dfs(nums,cur);
            cur.RemoveAt(cur.Count-1);
            check[i] = false;
        }
    }
}

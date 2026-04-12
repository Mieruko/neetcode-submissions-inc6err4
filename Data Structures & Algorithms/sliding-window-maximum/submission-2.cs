public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        List<int> res = new List<int>();
        int max = int.MinValue;

        if(k==1) return nums;

        int l=0;
        for(int r=0;r<nums.Length;r++){
            max = Math.Max(max,nums[r]);
            if(r-l+1 ==k){
                res.Add(max);
                if(nums[l] == max){
                    max = int.MinValue;
                    for (int i = l + 1; i <= r; i++) {
                        max = Math.Max(max, nums[i]);
                    }
                }
                l++;
            }
        }

        return res.ToArray();
    }
}

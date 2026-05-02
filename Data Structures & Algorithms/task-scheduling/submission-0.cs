public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] count = new int[26];
        foreach(char k in tasks){
            count['Z' - k]++;
        }
        int iMax = count.Max();
        int ni = 0;
        foreach(int num in count){
            if(iMax == num){
                ni++;
            }
        }

        int res = iMax*(n+1) - n + (ni -1);
        return Math.Max(tasks.Length,res);
    }
}

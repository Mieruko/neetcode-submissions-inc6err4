public class Solution {
    public string LongestPalindrome(string s) {
        int start =0 , end =0;
        for(int i=0; i<s.Length;i++){
            int odd = panlind(i , i , s);
            int even = panlind(i, i+1 ,s);

            int len = Math.Max(odd,even);
            if(len > end-start){
                start = i - (len - 1)/2;
                end = i + len/2;
            }
        }

        return s.Substring(start,end-start+1);
    }

    public int panlind(int l , int r, string s){
        while(l>=0 && r<s.Length && s[l] == s[r]){
            l--;
            r++;
        }

        return r-l-1;
    }
}

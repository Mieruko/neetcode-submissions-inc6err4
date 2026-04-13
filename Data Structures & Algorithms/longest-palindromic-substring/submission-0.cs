public class Solution {
    public string LongestPalindrome(string s) {
        string res = "";
        for(int i=0;i< s.Length;i++){
            for(int j =i;j<s.Length;j++){
                string sub = s.Substring(i,j-i+1);

                if(IsPalindromic(sub) && sub.Length > res.Length){
                    res = sub;
                }
            }
        }

        return res;
    }

    public bool IsPalindromic(string s){
        int l =0, r = s.Length-1;

        while(l<r){
            if(s[l] != s[r]) return false;
            l++;
            r--;
        }

        return true;
    }
}

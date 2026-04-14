public class Solution {
    public string LongestPalindrome(string s) {
        bool[,] db = new bool[s.Length,s.Length];

        int index = 0;
        int resLen = 0;

        for(int i = s.Length-1 ; i >= 0 ; i--){
            for(int j = i; j < s.Length ; j++){
                if(s[i] == s[j] && (j - i <= 2 || db[i+1, j-1]))
                {
                    db[i,j] = true;

                    if(resLen < (j-i+1)){
                        index = i;
                        resLen = j-i+1;
                    }
                }
            }
        }

        return s.Substring(index,resLen);
    }
}

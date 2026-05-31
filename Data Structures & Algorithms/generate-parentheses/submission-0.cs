public class Solution {  
    List<string> res;
    public List<string> GenerateParenthesis(int n) {
        res = new List<string>();
        string stack ="";
        dfs(0,0,n,stack);
        return res;
    }


    public void dfs(int left, int right, int n, string stack){
        if(left == right && right == n){
            res.Add(stack);
        }

        if(left < n){
            dfs(left + 1,right,n,stack + "(");
        }

        if(right < left){
            dfs(left,right+1,n,stack + ")");
        }
    }
}

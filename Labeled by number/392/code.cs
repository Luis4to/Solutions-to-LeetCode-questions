public class Solution {
    /*public bool IsSubsequence(string s, string t) returns true if s is a subsequence of t. A subsequence of a string 
     t is another string s that can be formed with the letters of t preserving their relative order */
    public bool IsSubsequence(string s, string t) {
        if(s.Length==0) return true; /* Outlier*/
        if(t.Length<s.Length)return false; /* Outlier*/
        if(t.Length==s.Length){ /* Special case */
            if(t==s)return true;
            else return false;
        }
        int start=0; /* start counts the number of letters of t used or discarded*/
        for(int i=0;i<s.Length;i++){
            if(s[i]!=t[start])i--;/* Here we need to keep i as it is for the next step, since we cant use t[start]*/
            start++; /* We either use or discard t[start]. Either way, we cannot use t[start] in the next step */
            if(start>=t.Length && i<s.Length-1)return false; /* This line executes if we used or discarded all of t */
        }
        return true; /* This line executes if we do not need more letters of t to construct s */
    }
}

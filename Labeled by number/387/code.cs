public class Solution {
    /* public int FirstUniqChar(string s) returns the first non-repeating character of string s. */
    public int FirstUniqChar(string s) {
        bool[] once=new bool[26]; /* once[i] stores whether the ith letter of alphabet is at least once in s*/
        bool[] twice=new bool[26]; /* twice[i] stores whether the ith letter of alphabet is at least twice in s*/
        for(int i=0;i<s.Length;i++){
            int index=Convert.ToInt32(s[i])-Convert.ToInt32('a');
            if(once[index]==false)once[index]=true; /*The first time we find the index-th letter we set once[index]=true */
            else twice[index]=true; /* The any further time we set twice[index]=true */
        }
        for(int i=0; i<s.Length;i++){/* We iterate in order from start to finish to find the first unique character*/
            int index2=Convert.ToInt32(s[i])-Convert.ToInt32('a');
            if(twice[index2]==false)return i; /* twice[index2]==false means that the s[i] is a unique character in s*/
        }
        return -1;/* We found no unique character, i.e. every character in s is repeated at least once.*/
    }
}

public class Solution {
    /*public char FindTheDifference(string s, string t) finds the extra character in string t relative to s */
    /* t is formed by adding a character to s and reshuffling */
    public char FindTheDifference(string s, string t) {
        int[] letters=new int[26];/*Stores the number of occurrences of a letter in t minus number of occurrences in s*/
        for(int i=0;i<t.Length;i++){
            letters[Convert.ToInt32(t[i])-Convert.ToInt32('a')]++; /* Counting occurrences in t as positive*/
        }
        for(int i=0;i<s.Length;i++){
            letters[Convert.ToInt32(s[i])-Convert.ToInt32('a')]--; /* Subtracting occurrences in s*/
        }
        for(int i=0;i<26;i++){
            if(letters[i]==1)return Convert.ToChar(i+Convert.ToInt32('a')); /* There should be only one i with letters[i]=1*/
        }
        return '!'; /*This return should never be executed, added only in case of an error */
    }
}

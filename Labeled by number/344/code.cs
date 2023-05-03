public class Solution {
    /* ReverseString(char[] s) reverses the array of characters s*/
    public void ReverseString(char[] s) {
        for(int i=0;i<s.Length/2;i++){ /*This part of the code exchanges s[i] with s[s.Length-1-i] */
            char a=s[i]; 
            s[i]=s[s.Length-1-i];
            s[s.Length-1-i]=a;
        }
        return; 
    }
}

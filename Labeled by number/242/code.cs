public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)return false;/* Minimum requirement for consideration */
        int[] num_instances=new int[1000]; /* This may be overkill, size can be reduced*/
        for(int i=0;i<s.Length;i++){
            num_instances[Convert.ToInt32(s[i])]++; /* Storing number of occurrences of each character */
        }
        for(int i=0;i<t.Length;i++){
            num_instances[Convert.ToInt32(t[i])]--;/* We only want to check if the number of occurrences are
                                                   ** the same, so we subtract in hopes to get 0 at the
                                                   end*/
        }
        for(int i=0;i<1000;i++){
            if(num_instances[i]!=0)return false; /* If there is a nonzero element in the array, it is 
                                                ** not an anagram*/
        }
        /*If we reach this point we have an anagram */
        return true;
    }
}

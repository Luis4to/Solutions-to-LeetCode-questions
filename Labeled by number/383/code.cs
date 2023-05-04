public class Solution {
    /* public bool CanConstruct(string ransomNote, string magazine)  returns true if ransomNote can be constructed
    with the letters of magazine. Each letter of magazine can be used the same number of times they appear in magazine */
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] letters=new int[26]; /* Stores occurrences of letters */
        for(int i=0;i<magazine.Length;i++){
            int index=Convert.ToInt32(magazine[i])-Convert.ToInt32('a'); 
            letters[index]++; /* adds 1 per occurrence of the index-th letter of the english alphabet*/
        }
        for(int i=0;i<ransomNote.Length;i++){
            int index=Convert.ToInt32(ransomNote[i])-Convert.ToInt32('a');
            letters[index]--; /* Substracts 1 per use if the index-th letter of the english alphabet in ransomNote*/
            if(letters[index]<0)return false; /* This is executed if we used more letters than we have */
        }
        return true;/* This point is reached if ransomNote can be successfuly constructed*/
    }
}

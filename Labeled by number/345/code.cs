public class Solution {
    /*public string ReverseVowels(string s) reverses the relative order of the vowels in string */
    public string ReverseVowels(string s) {
        StringBuilder reversedString=new StringBuilder(); /* Stores the result */
        StringBuilder vowels=new StringBuilder(); /* stores the vowels*/
        for(int i=0;i<s.Length;i++){
            if(IsVowel(s[i]))vowels.Append(s[i]); /* we put all the vowels in  StrinBuilder vowels */
        }
        int j=vowels.Length-1; /* Iterator to go through vowels backwards*/
        for(int i=0;i<s.Length;i++){
            if(IsVowel(s[i])){
                reversedString.Append(vowels[j]); /* We insert vowels in the place where a vowel should be, reversed */
                j--;
            }
            else reversedString.Append(s[i]); /* We insert consonants in the same place */
        }
        return reversedString.ToString(); /* Returns final result with no issues*/
    }


    /* public bool IsVowel(char a) is an auxiliar function which returns true if a is a vowel, and false otherwise */
    public bool IsVowel(char a){
        return a=='a' ||a=='e' || a=='i' || a=='o' || a=='u' || a=='A' ||a=='E' || a=='I' || a=='O' || a=='U'; 
    }
}

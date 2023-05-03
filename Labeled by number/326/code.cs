public class Solution {
    /* IsPowerOfThree(int n) returns true if n is a positive power of 3, and false otherwise*/
    public bool IsPowerOfThree(int n) {
        if(n<1)return false; /* Outliar */
        if(n==1)return true; /* Base case*/
        if(n%3==0) return IsPowerOfThree(n/3); /* A  positive power of 3 greater than 1 divided by 3 is also a positive 
                                                **power of 3*/
        else return false; /* At some point we get a number that is different from 1, and not divisible by 3, hence false*/
    }
}

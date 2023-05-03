public class Solution {
    /* IsPowerOfFour(int n) returns true if n is a positive power of 4, and false otherwise.*/
    public bool IsPowerOfFour(int n) {
        if(n<1)return false; /* There are no positive powers of 4 smaller than 1*/
        if(n==1)return true; /* Base case*/
        if(n%4==0)return IsPowerOfFour(n/4); /* If the result of n/4 for n>1 is a positive power of 4, then n was a positive 
                                             **power of 4*/
        return false; /* If we reach this point it means n is greater than 1 and not a multiple of 4, hence false*/
    }
}

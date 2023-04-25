public class Solution {
    /*IsPowerOfTwo checks whether n is a power of two or not*/
    public bool IsPowerOfTwo(int n) {
        if(n==0)return false;/* Outlier*/
        if(n==1)return true; /* Base case*/
        if(n%2==1) return false;/* Every power of 2 greater than 1 is even*/
        return IsPowerOfTwo(n/2);/* Every power of 2 greater than 1 divided by 2 is a power of 2*/
    }
}

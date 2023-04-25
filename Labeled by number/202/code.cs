public class Solution {
    /* IsHappy checks if n is a happy number*/
    public bool IsHappy(int n) {
        /* We store the values of n already obtained in visited. It is not possible to obtain more
        ** than 800 by adding the squared digits of n with the problem constrains  */
        bool[] visited=new bool[800];
        /* We replace n with sumSquaredDigits(n) at each step, if we arrive at 1  then n is happy, */
        while(n!=1){
            n=sumSquaredDigits(n);
            if(visited[n])return false; /* If we already obtained n before it means n is not happy*/
            visited[n]=true; /* We need to remember that we visited n just now. */
        }
        return true; /*Happyness achieved */
    }

    /*sumSquaredDigits sums the squared digits of n recursively  */ 
    public int sumSquaredDigits(int n){
        if(n==0)return 0; /* Base case*/
        /* We square the units digit, and add to the result of the same process on the leading n-1 digits*/
        return (n%10)*(n%10)+sumSquaredDigits(n/10); 
    }
}

public class Solution {
    public int[] CountBits(int n) {
        int[] ans=new int[n+1]; /*Stores the output */
        if(n==0)return ans; /* Base case*/
        int m=1;
        while(2*m<=n)m=2*m; /* We the largest power of 2, that is smaller or equal to n*/
        int[] prevAns=CountBits(m-1); /* We compute the result for m-1*/
        for(int i=0;i<m;i++)ans[i]=prevAns[i]; /* The first m elements are the same elements than prevAns*/
        for(int i=m;i<n+1;i++)ans[i]=prevAns[i-m]+1; /* The next elements are obtained by adding 1 to each prevAns[i]*/
        return ans;
    }
}

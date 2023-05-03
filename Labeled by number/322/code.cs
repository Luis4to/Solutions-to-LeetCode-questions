public class Solution {
/*  public int CoinChange(int[] coins, int amount)  returns the smallest amount of coins needed to pay amount.
**  Array coins stores the different denominations possible*/
    public int CoinChange(int[] coins, int amount) {
        int n=coins.Length; /*Style choice */
        int[,] dp=new int [n, amount+1]; /* We store the solutions to smaller problems in dp[i,j], where i indicates how many
                                        ** of the first elements from coins to ignore, and amount indicates the remaining 
                                        ** amount to pay.*/
        for(int j=0; j<amount+1;j++){
            if(j%coins[n-1]==0)dp[n-1,j]=j/coins[n-1]; /* Base case where we only use the last denomination, and 
                                                        ** in principle there can be any amount from 0 to amount remaining 
                                                        ** to pay*/
            else dp[n-1,j]=-1; /* When it is not possible to pay amount, we store -1*/
        }

        for(int i=n-2;i>=0;i--){/* We iterate over the rest of possible smaller problems to solve */
            for(int j=1; j<amount+1;j++ ){
                dp[i,j]=10001;
                for(int k=0; k*coins[i]<=j;k++){/* We iterate over how many times we use coins[i] and choose accordingly*/
                    if(dp[i+1,j-k*coins[i]]>-1)dp[i,j]=Math.Min(dp[i,j],k+dp[i+1,j-k*coins[i]]); 
                }
                if(dp[i,j]==10001)dp[i,j]=-1; /* If dp[i,j]==10001 it means that we did not find any way to solve the problem
                                             ** with the denominations from i to n-1, and with remaining amount j*/
            }
        }
        return dp[0,amount]; /* 0 indicates to use the whole array coins, and amount indicates that we want the full amount */ 
    }

   
}

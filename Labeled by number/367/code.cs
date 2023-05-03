public class Solution {
    /*public bool IsPerfectSquare(int num) returns true if num is a perfect square, otherwise it returns false */
    public bool IsPerfectSquare(int num) {
        if (num==1) return true; /* Trivial case*/
        int left=0;
        int right=num/2;
        /* We now perform binary search to look for the best candidate for the square root of num */
        while(left+1<right){
            int middle=(left+right)/2; 
            if(num%middle==0 && middle==num/middle)return true;
            if(middle>num/middle)right=middle;
            else left=middle;
        }
        /* There is a chance that left!=right at this point, but instead left+1=right */
        if(left*left==num)return true; /* We try left as the square root of num */
        if(right*right==num)return true; /* We try right as the square root of num*/
        return false; /*If we reach this point it means there is no suitable integer who is the sqrt of num */
    }
}

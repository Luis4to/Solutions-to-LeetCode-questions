public class Solution {
    /*MissingNumber(nums) returns the integer from 0 to nums.Length that is missing in nums */
    public int MissingNumber(int[] nums) {
        int missingNumber= (nums.Length+1)*nums.Length/2; /* (nums.Length+1)*nums.Length/2 is the sum of numbers from 0 to
                                                        **  nums.Length. */
        for(int i=0;i<nums.Length;i++){
            missingNumber-=nums[i]; /* missing number is the number that is not substracted*/
        }
        return missingNumber; /* All the numbers that are in nums were substracted, the one left is the missing one*/
    }
}

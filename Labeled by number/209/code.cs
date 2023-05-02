public class Solution {

    /*MinSubarrayLen(target, nums) outputs the subarray of nums with sum larger or equal to target with smallest size */
    public int MinSubArrayLen(int target, int[] nums) {
        int sum=0; /* Stores the sum of the elements in the subarray*/
        int start=0; /* Starting element of subarray*/
        int minimumSubArrayLen=nums.Length+1; /* Stores the minimum size of a subarray satisfying the condition*/
        for(int end=0; end<nums.Length;end++){ /* We iterate through the last element of the subarray */
            sum+=nums[end]; /* We add the last element to sum */
            if(sum>=target){/* Subarray meets the condition */
                minimumSubArrayLen=Math.Min(minimumSubArrayLen,end-start+1); /* We update our answer*/
                sum-=nums[start]; /* Now we move the start to see if we get a better answer*/
                start++; 
                sum-=nums[end]; /* We must go back to before including the last element*/
                end--;
            }
            if(start>= nums.Length)break; /* If start goes out of bounds we stop*/
        }
        return minimumSubArrayLen%(nums.Length+1); /* We want to return 0 if no such subarray is found*/
    }
}

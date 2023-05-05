public class Solution {
    /* public int[] TwoSum(int[] nums, int target) returns the two different indices of the two elements of nums that add to 
    **target. It is assumed  that there is exactly one pair of elements in nums satisfying that condition.*/
    public int[] TwoSum(int[] nums, int target) {
        int n=nums.Length; /* Style choice*/
        for(int i=0; i<n-1;i++){ /* We iterate through all the possible ways to choose the first element */
            for(int j=i+1;j<n;j++){ /* We iterate through the possible ways to choose the second element after index i */
                if(nums[i]+nums[j]==target){ /* We check the condition */
                    int[] O= {i,j}; /* To store the pair of indices */
                    return O; /* And return it*/
                }
            }
        }
        int[] Error= {-1,-1};
        return Error; /* This should never happen outside of leetcode, but in case there is no pair we output {-1,-1}*/
    }
}

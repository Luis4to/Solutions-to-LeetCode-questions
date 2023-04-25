public class Solution {

    /* ContainsDuplicate checks whether nums contains at least one duplicate */
    public bool ContainsDuplicate(int[] nums) {
        Array.Sort(nums);/* Duplicates are adjacent when the array is sorted*/
        for(int i=1;i<nums.Length;i++){
            if(nums[i]==nums[i-1])return true;/* Checking for adjacent duplicates*/
        }
        return false; /* If we reach this point it means we found no duplicates */
    }
}

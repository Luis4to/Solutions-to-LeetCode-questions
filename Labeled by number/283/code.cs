public class Solution {
    /*MoveZeroes moves the zeroes in nums to the end */
    public void MoveZeroes(int[] nums) {
        /*We first iterate through the array nums to find the zeroes */
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==0){/*If we find a zero, we look for the closest nonzero number and exchange them */
                for(int j=i+1;j<nums.Length;j++){
                    if(nums[j]!=0){/* If we find a nonzero number we exchange num[i] and num[j]*/
                        nums[i]=nums[j];
                        nums[j]=0;
                        break; /* We finish and continuelooking for zeroes*/
                    }
                }
            }
        }
        return; /* At this point, the array should have the desired form */
    }
}

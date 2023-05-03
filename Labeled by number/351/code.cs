public class Solution {
    /*public int[] Intersect(int[] nums1, int[] nums2) returns the intersection of nums1 and nums 2
    ** where each alements appears as many times as it appears in both arrays simultaneously. */
    public int[] Intersect(int[] nums1, int[] nums2) {
        int[] memory1=new int[1001]; /* Stores number of occurrences of a number i in array nums1*/
        int[] memory2=new int[1001]; /* Stores number of occurrences of a number i in array nums2*/
        for(int i=0;i<nums1.Length;i++){
            memory1[nums1[i]]++; /*Filling up memory1 */
        }
        for(int i=0;i<nums2.Length;i++){
            memory2[nums2[i]]++;/*Filling up memory2 */
        }
        int numElements=0;
        for(int i=0;i<1001;i++){
            memory1[i]=Math.Min(memory1[i],memory2[i]); /*We want the number of simultaneous occurrences in nums1 and nums2*/
            numElements+=memory1[i];/* We count the number of elements of the final array */
        }
        int[] newArray=new int[numElements]; /* To store the final array*/
        for(int i=0;i<1001;i++){
            while(memory1[i]>0){ /* We need to insert i, memory[i] times into newArray*/
                newArray[numElements-1]=i;
                numElements--;
                memory1[i]--;
            }
        }
        return newArray; /* Returns the final array*/
    }
}

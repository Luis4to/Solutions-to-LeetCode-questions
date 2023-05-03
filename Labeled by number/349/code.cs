public class Solution {
    /*Intersection(int[] nums1, int[] nums2) returns intersection of two arrays nums1 and nums2 with no repeated elements*/
    public int[] Intersection(int[] nums1, int[] nums2) {
        bool[] memory1=new bool[1001]; /* memory1[i] stores whether i is in nums1*/
        bool[] memory2=new bool[1001]; /* memory2[i] stores whether i is in nums2*/
        
        for(int i=0;i<nums1.Length;i++){
            memory1[nums1[i]]=true;
        }
        for(int i=0;i<nums2.Length;i++){
            memory2[nums2[i]]=true;
        }
        int numElements=0; /* Stores the number of elements of newArray*/ 
        for(int i=0;i< 1001;i++){
            if(memory1[i] && memory2[i])numElements++; /* Here we compute the number of elements of newArray*/
        }
        int[] newArray=new int[numElements]; /*Stores result */
        int index=0; 
        for(int i=0;i<1001;i++){
            if(memory1[i] && memory2[i]){ 
                newArray[index]=i; /* We add numbers i that are in both nums1 and nums 2 once*/
                index++;
            }
        }
        return newArray;/*Final result */
    }
}

public class NumArray {
    int n; /* Size of original array nums, and number of leaves of the segmentTree */
    int[] segmentTree; /* segmentTree[i] stores the sum of the elements of nums from index left to index 
                       **right, where left and right are further described in UpdateNode*/
    
    /*Constructor of the NumArray object, which determines the size of segmentTree, initializes each 
    **leave of the segmentTree with the values in nums, and computes the sums corresponding to each node */
    public NumArray(int[] nums) {
        n=nums.Length;/* Initializing n*/
        segmentTree=new int[2*n-1]; /*Minimum possible size of segmentTree is 2n+1, shown by induction*/
        for(int i=0;i<n;i++){
            Update(i,nums[i]); /* Initialization of the segmentTree from bottom to top*/
        }
    }

    /*Updates the children of node and node in the segment tree.*/
    public void UpdateNode(int node, int index, int val, int left, int right){
        /* If node is a leaf, then we update segmentTree[node] to the given val */
        if(left==right && left==index){
            segmentTree[node-1]=val;
            return;
        }
        /* If the interval [left,right] associated to node does not contain index, do nothing */
        if(left==right)return;
        /* We separate the interval [left,right] into two intervals [left,mid] and [mid+1,right] with sizes
        ** differing by at most 1. */
        int mid=(left+right)/2;
        /* If index is in [left,mid], update the left child of node*/
        if(left<= index && index <= mid) UpdateNode(node+1,index, val,left, mid);
        /* If index is instead in [mid+1,right], update the right child of node */
        else UpdateNode(node+2*(mid-left+1),index, val,mid+1, right);
        /* The integer index cannot be in both [left,mid] and [mid+1,right], and there is no need 
        to update the child that does not contain index, since nums[index] does not contribute 
        ** to the sum. The value of nodes is the sum of its two children*/
        segmentTree[node-1]=segmentTree[node]+segmentTree[node+2*(mid-left)+1];
        return;
    }
    /*Updates all the nodes of segmentTree by using UpdateNode*/
    public void Update(int index, int val) {
        /* UpdateNode updates a node and its children, therefore it is enough to call it on the root 
        ** to update the whole segmentTree. The root's value is the sum of all the n elements of nums*/
        UpdateNode(1,index,val,0, n-1);
        return;
    }
    /* SumRange returns the sum of all the elements in nums with indices between left and right, inclusive*/
    public int SumRange(int left, int right) {
        /* Evaluates the auxiliary function SumNode at the root*/
        return SumNode(1,left,right,0, n-1);      
    }
    /* SumNode computes the sum of all elements of nums with indices from left to right, inclusive, 
    ** which are contained in the interval [start, end] associated to node */
    public int SumNode(int node, int left, int right, int start, int end){
        /* If [left,right] and [start,end] are disjoint, the result is zero since we are adding nothing*/
        if(right <start || end< left) return 0;
        /* If [start,end] is a subinterval of [left,right], we return the value of the node */
        if(left <=start && end <= right )return segmentTree[node-1];
        /* Divide [start,end] into two intervals [start, mid] and [mid,end], associated to the children of 
        ** node. The result is obtained by combining the results for each child of node. */
        int mid= (start+end)/2;
        return SumNode(node+1, left, right, start, mid)+SumNode(node+2*(mid-start+1), left, right, mid+1, end);
    }
}

/** 
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    /* Inverts the binary tree associated to root, and returns its root, recursively */
    public TreeNode InvertTree(TreeNode root) {
        if(root==null)return root; /* Base case */
        TreeNode a=InvertTree(root.left); /* Inverting the subtree on the left*/
        TreeNode b=InvertTree(root.right); /* Inverting the subtree on the right*/
        root.left=b;/* Reversing the roles of the left and right child*/
        root.right=a; /* Reversing the roles of the left and right child*/
        return root; 
    }
}

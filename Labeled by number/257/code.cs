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
    /*BinaryTreePaths returns each path from root to leaf of a binary tree as a string with arrows */
    public IList<string> BinaryTreePaths(TreeNode root) {
        IList<string> paths=new List<string>();/* To store the final answer*/
        if(root.left==null && root.right==null){ /* Condition to find a leaf */
            paths.Add(Convert.ToString(root.val)); /* There is only one path in this case */
            return paths;
        }
        if(root.left!=null){/* Checks if there is a left child*/
            IList<string> leftPaths=BinaryTreePaths(root.left); /* Solves the problem for the subtree of 
                                                                ** the left child*/
            for(int i=0;i< leftPaths.Count;i++){
                paths.Add(Convert.ToString(root.val)+"->"+leftPaths[i]); /* Merging paths to math
                                                                        **  the original binary tree*/
            }
        }
        if(root.right!=null){/* Checks if there is a right child*/
            IList<string> rightPaths=BinaryTreePaths(root.right);/* Solves the problem for the subtree of 
                                                                ** the right child*/
            for(int i=0;i< rightPaths.Count;i++){
                paths.Add(Convert.ToString(root.val)+"->"+rightPaths[i]);/* Merging paths to math
                                                                        **  the original binary tree*/
            }
        }
        return paths; /* Returning all the paths from root to leaf*/
    }
}

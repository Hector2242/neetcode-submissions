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
    public int MaxDepth(TreeNode root) {
        
        if(root == null){
            return 0;
        }

        HashSet<TreeNode> seen = new HashSet<TreeNode>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root); //now root is in the stack
        int depth = 1;

        while(stack.Count != 0){
            var node = stack.Peek(); //it reads the top node without removing it.
            if ((node.left != null) && !seen.Contains(node.left)) {
                stack.Push(node.left);
            } else if ((node.right != null) && !seen.Contains(node.right)) {
                stack.Push(node.right);
            } else {
                if (depth < stack.Count) {
                    depth = stack.Count;
                }

                seen.Add(stack.Pop());
            }

        }

        return depth;

    }
}

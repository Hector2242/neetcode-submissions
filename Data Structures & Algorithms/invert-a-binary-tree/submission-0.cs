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

// function invertTree(root):
//     if root == null:
//         return null

//     stack = [root]
//     while stack is not empty:
//         node = stack.pop()
//         swap(node.left, node.right)
//         if node.left  != null: stack.push(node.left)
//         if node.right != null: stack.push(node.right)

//     return root

public class Solution {
    public TreeNode InvertTree(TreeNode root) {

        if(root == null){ //base case if empty
            return null;
        }

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count != 0){
            var node = stack.Pop();
            (node.left, node.right) = (node.right, node.left);

            if(node.left != null){
                stack.Push(node.left);
            }

            if(node.right != null){
                stack.Push(node.right);
            }
        }

        return root;
        
    }
}

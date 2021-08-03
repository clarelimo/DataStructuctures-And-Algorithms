using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
    public static class CoreUtil
    {
        public static int HeightBinaryTree(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            else
            {
                int lh = HeightBinaryTree(root.left);
                int rh = HeightBinaryTree(root.right);

                return Math.Max(lh, rh) + 1;
            }
        }

        public static int NodesInBinaryTreeIterative(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            else
            {
                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                int count = 0;

                while(queue.Count > 0)
                {
                    TreeNode node = queue.Dequeue();
                    count++;

                    if(node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if(node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                return count;
            }
        }

        public static int NodesInBinaryTreeRecursive(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            else
            {
                int countl = NodesInBinaryTreeRecursive(root.left);
                int countr = NodesInBinaryTreeRecursive(root.right);

                return countl + countr + 1;
            }
        }

        public static int LeafNodesIterative(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                int count = 0;

                while (queue.Count > 0)
                {
                    TreeNode node = queue.Dequeue();
                    if(node.left == null && node.right == null)
                    {
                        count++;
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                return count;
            }
        }

        public static int LeafNodesRecursive(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }else if(root.left == null && root.right == null)
            {
                return 1;
            }
            else
            {
                int countl = LeafNodesRecursive(root.left);
                int countr = LeafNodesRecursive(root.right);

                return countl + countr;
            }
        }

        public static int BalancedHeight(TreeNode root)
        {
            if (root == null) return 0;

            int leftHeight = BalancedHeight(root.left);
            int rightHeight = BalancedHeight(root.right);

            if (leftHeight == -1 || rightHeight == -1) return -1;

            if (Math.Abs(leftHeight - rightHeight) > 1) return -1;

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public static bool IsBalanced(TreeNode root)
        {
            int height = BalancedHeight(root);
            if (height > -1) return true;
            return false;
        }

        public static bool IsValidBST(TreeNode root, int min, int max)
        {
            if (root == null) return true;

            if (root.data <= min || root.data >= max) return false;

            return IsValidBST(root.left, min, root.data) && IsValidBST(root.right, root.data, max);
        }

        public static bool IsValidBSTIterative(TreeNode root)
        {
            var st = new Stack<TreeNode>();
            int min = int.MinValue;

            while(st.Count > 0 || root != null)
            {
                if(root != null)
                {
                    st.Push(root);
                    root = root.left;
                }
                else
                {
                    root = st.Pop();
                    if (root.data <= min) return false;
                    min = root.data;
                    root = root.right;
                }
            }

            return true;
        }

        public static int LeastCommonAncestorIterative(TreeNode root,int n1, int n2)
        {
            if (root == null) return 0;

            if (root.data == n1 || root.data == n2) return root.data;

            int leftNode = LeastCommonAncestorIterative(root.left, n1, n2);
            int rightNode = LeastCommonAncestorIterative(root.right, n1, n2);

            if (leftNode != 0 && rightNode != 0) return root.data;

            return (leftNode != 0) ? leftNode : rightNode;
        }

        public static int GoodNodes(TreeNode root, int max, int count)
        {
            if (root == null) return 0;

            if (root.data >= max)
            {
                max = root.data;
                count++;
            }
            if (root.left != null)
            {
               count = GoodNodes(root.left, max,count);
            }

            if (root.right != null)
            {
               count = GoodNodes(root.right, max,count);
            }

            return count;
        }

        public static TreeNode CreateBst(int[] arr)
        {
            return Helper(arr, 0, arr.Length - 1);
        }

        public static TreeNode Helper(int[] arr, int start, int end)
        {
            if (end < start) return null;

            int mid = (start + end) / 2;
            TreeNode root = new TreeNode(arr[mid]);

            root.left = Helper(arr, start, mid-1);
            root.right = Helper(arr, mid + 1, end);
 
            return root;
        }

        public static void PrintNodes(TreeNode root)
        {
            if(root != null)
            {
                PrintNodes(root.left);
                if(root.left != null && root.right != null)
                {
                    Console.WriteLine(root.data);
                }
                PrintNodes(root.right);
            }
        }
    }
}

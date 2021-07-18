using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
    public static class TraversalUtil
    {
        public static void PreOrderTraversal(TreeNode root)
        {
            if(root == null)
            {
                return;
            }
            else
            {
                Console.Write($"{root.data}, ");
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
            }
        }

        public static void PreOrderIteratetive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                var st = new Stack<TreeNode>();
                TreeNode node = root;

                while ((node != null) || (st.Count > 0))
                {
                    if (node != null)
                    {
                        Console.Write($"{node.data}, ");
                        st.Push(node);
                        node = node.left;
                    }
                    else
                    {
                        node = st.Pop();
                        node = node.right;
                    }
                }
            }
        }

        public static void InOrderTraversal(TreeNode root)
        {
            if(root == null)
            {
                return;
            }
            else
            {
                InOrderTraversal(root.left);
                Console.Write($"{root.data}, ");
                InOrderTraversal(root.right);
            }
        }

        public static void InOrderIteratetive(TreeNode root)
        {
            if(root == null)
            {
                return;
            }
            else
            {
                var st = new Stack<TreeNode>();
                TreeNode node = root;

                while ((node != null) || (st.Count > 0))
                {
                    if(node != null)
                    {
                        st.Push(node);
                        node = node.left;
                    }
                    else
                    {
                        node = st.Pop();
                        Console.Write($"{node.data}, ");
                        node = node.right;
                    }                   
                }
            }
        }

        public static void PostOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                PostOrderTraversal(root.left);
                PostOrderTraversal(root.right);
                Console.Write($"{root.data}, ");
            }
        }

        public static void PostOrderIteratetive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                var st = new Stack<TreeNode>();
                var st2 = new Stack<TreeNode>();  // contains the output
                TreeNode node = root;

                while ((node != null) || (st.Count > 0))
                {
                    if (node != null)
                    {
                        st.Push(node);
                        st2.Push(node);
                        node = node.right;
                    }
                    else
                    {
                        node = st.Pop();
                        node = node.left;
                    }
                }

                while(st2.Count > 0)
                {
                    TreeNode popped = st2.Pop();
                    Console.Write($"{popped.data}, ");
                }
            }
        }

        public static void LevelOrderTraversal(TreeNode root)
        {
            if(root == null)
            {
                return;
            }
            else
            {
                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);

                while(queue.Count > 0)
                {
                    TreeNode node = queue.Dequeue();
                    Console.Write($"{node.data}, ");

                    if(node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if(node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }
        }



    }
}

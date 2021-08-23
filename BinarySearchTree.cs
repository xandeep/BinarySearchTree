using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    class BinarySearchTree
    {
        public class Node
        {
            public int Data;
            public Node LeftChild;
            public Node RightChild;

            public Node(int data)
            {
                Data = data;
            }
        }

        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int data)
        {
            Node NewNode = new Node(data);
            if (root == null)
            {
                root = NewNode;
            }
            else
            {
                Node curent = root;
                while (true)
                {
                    if (data < curent.Data)
                    {
                        // check if left node is empty 
                        // if empty you can add value here
                        // else keep going left.

                        if (curent.LeftChild == null)
                        {
                            curent.LeftChild = NewNode;
                            return;
                        }
                        else
                        {
                            curent = curent.LeftChild;
                            continue;
                        }


                    }

                    if (data > curent.Data)
                    {
                        // check if right node is empty 
                        // if empty you can add value here
                        // else keep going right.

                        if (curent.RightChild == null)
                        {
                            curent.RightChild = NewNode;
                            return;
                        }
                        else
                        {
                            curent = curent.RightChild;
                            continue;
                        }
                    }

                }
            }
        }


        public void PreOrderTraverse(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                PreOrderTraverse(node.LeftChild);
                PreOrderTraverse(node.RightChild);
            }

        }

        public void PostOrderTraverse(Node node)
        {
            if (node != null)
            {
                PostOrderTraverse(node.LeftChild);
                PostOrderTraverse(node.RightChild);
                Console.Write(node.Data + " ");
            }

        }

        public void InOrderTraverse(Node node)
        {
            if (node != null)
            {
                InOrderTraverse(node.LeftChild);
                Console.Write(node.Data + " ");
                InOrderTraverse(node.RightChild);
            }

        }

        public void DeleteNode(ref Node root, int value)
        {
            if (value < root.Data)
            {
                DeleteNode(ref root.LeftChild, value);
            }

            if (value > root.Data)
            {
                DeleteNode(ref root.RightChild, value);
            }

            if (value == root.Data)
            {
                if (root.LeftChild == null)
                {
                    root = root.RightChild;
                    return;
                }

                if (root.RightChild == null)
                {
                    root = root.LeftChild;
                    return;
                }

                // if both sides are not  null, then we get lowest value from right sub tree
                Node MinNode = GetMinimumNode(root.RightChild);
                DeleteNode(ref root.RightChild, MinNode.Data);
                root.Data = MinNode.Data;
            }
        }

        Node GetMinimumNode(Node root)
        {

            if (root.LeftChild != null)
            {
                return GetMinimumNode(root.LeftChild);
            }
            return root;



        }

    }
}

using System;

namespace DSA
{
    class Binary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Search Tree!");
            BinarySearchtree tree = new BinarySearchtree();
            tree.Insert(100);
            tree.Insert(75);
            tree.Insert(85);
            tree.Insert(65);
            tree.Insert(80);
            tree.Insert(105);
            tree.Insert(25);
            tree.Insert(35);
            tree.Insert(110);
            tree.Insert(115);
            tree.Insert(95);
        }
    }

    class BinarySearchtree
    {
        public class Node
        {
            public  int Data;
            public Node LeftChild;
            public Node RightChild;

            public Node(int data)
            {
                Data = data;
            }
        }

        public Node root;

        public BinarySearchtree()
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

                        if(curent.LeftChild == null)
                        {
                            curent.LeftChild = NewNode;
                            return;
                        } else
                        {
                            curent = curent.LeftChild;
                            continue;
                        }
                       
                      
                    }

                    if ( data > curent.Data)
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

    }
}

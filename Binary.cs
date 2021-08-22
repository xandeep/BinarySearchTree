﻿using System;

namespace DSA
{
    class Binary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Search Tree! \n");
            BinarySearchTree tree = new BinarySearchTree();

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
            tree.Insert(104);
            tree.Insert(106);
            tree.Insert(103);
            tree.Insert(109);

            Console.WriteLine("Pre-Order Traverse : ");
            tree.PreOrderTraverse(tree.root);

            Console.WriteLine("\n\nPost-Order Traverse : ");
            tree.PostOrderTraverse(tree.root);

            Console.WriteLine("\n\nIn-Order Traverse : ");
            tree.InOrderTraverse(tree.root);
        }
    }
}

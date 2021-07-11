using System;

namespace BinaryTreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Binary Search Tree--------------");
            BinaryTree<int> binaryTree = new BinaryTree<int>(56);
            //Insert elements 
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(11);
            binaryTree.Insert(65);
            binaryTree.Insert(3);
            binaryTree.Insert(16);
            binaryTree.Insert(63);
            binaryTree.Insert(67);
            //Dispaly elements ........
            binaryTree.Display();
            //Get the size of the tree.......
            binaryTree.GetSize();
        }
    }
}
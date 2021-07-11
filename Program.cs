using System;

namespace BinaryTreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Binary Search Tree--------------");
            BinaryTree<int> binaryTree = new BinaryTree<int>(56);

            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Display();
        }
    }
}
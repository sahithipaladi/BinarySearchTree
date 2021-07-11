using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeImplementation
{
    class BinaryTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinaryTree<T> LeftTree { get; set; }
        public BinaryTree<T> RightTree { get; set; }

        public BinaryTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0, rightCount = 0;

        //Insert elements
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinaryTree<T>(item);
                else
                    this.LeftTree.Insert(item);
                this.leftCount++;
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinaryTree<T>(item);
                else
                    this.RightTree.Insert(item);
                this.rightCount++;
            }
        }

        //Dispaly elements
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.RightTree.Display();
            }
        }

        //Get size of the tree
        public void GetSize()
        {
            Console.WriteLine("The size of Binary Search Tree is : " + (this.leftCount + this.rightCount + 1));
        }
    }
}
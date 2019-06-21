using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.CSharp
{
    /// <summary>
    /// Binary search tree (BST) is a binary tree where the value of each node is larger or equal to the values in all the nodes in that node's left subtree and is smaller than the values in all the nodes in that node's right subtree.
    /// Write a function that, efficiently with respect to time used, checks if a given binary search tree contains a given value.
    /// </summary>
    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public class BinarySearchTree
    {
        public static bool Contains2(Node root, int value)
        {
            Node currentNode = root;

            while (currentNode != null)
            { // Or whatever you use to signal that there is no node.
                switch (value.CompareTo(currentNode.Value))
                {
                    case -1:
                        currentNode = currentNode.Right;
                        break;
                    case 1:
                        currentNode = currentNode.Left;
                        break;
                    default: // case 0
                        return true;
                }
            }
            return false;
        }

        public static bool Contains(Node root, int value)
        {
            if (value.CompareTo(root.Value) == 0)
            {
                return true;//return 0 if found
            }
            else
            {
                if (value.CompareTo(root.Value) > 0)
                {
                    //root = node.Left;
                    Node left = root.Left;
                    return (Contains(root, value));
                }
                else
                {
                    if (value.CompareTo(root.Value) < 0)
                    {
                        //root = node.Right;
                        Node right = root.Right;
                        return (Contains(root, value));
                    }
                    else
                    {
                        return false;//return 1 if not found
                    }
                }
            }
        }
    }
}

using InterviewQuestions.CSharp;
using System;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Merge Names
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia

            //Palindrome
            Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));

            //Binary search tree
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(BinarySearchTree.Contains2(n2, 3));

            Console.WriteLine("Thanks!");
        }
    }
}

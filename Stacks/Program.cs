namespace Stacks {
    using System;

    internal class Node {
        public int Data { get; set; }
        public Node? Next { get; set; }
    }

    internal class Stack {
        public int Size { get; set; }
        public Node Top { get; set; }
    }

    public class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Stack implementation");

            Stack stack = new Stack ();
            
            Push (stack, 1);
            Push (stack, 2);
            Push (stack, 3);

            Peek (stack);

            Pop (stack);
            Pop (stack);
            Peek (stack);
        }

        static void Push (Stack stack, int data) {
            var newNode = new Node ();
            newNode.Data = data;
            newNode.Next = stack.Top;

            stack.Top = newNode;
        }

        static void Pop (Stack stack) {
            if (stack.Top == null) {
                Console.WriteLine ("Stack is empty.");
            } else {
                var data = stack.Top.Data;
                stack.Top = stack.Top.Next;
                Console.WriteLine ($"Pop items :{data}");
            }
        }

        static void Peek (Stack stack) {
            Console.WriteLine ("Print Stack : ");
            var topCopy = stack.Top;
            while (topCopy != null) {
                Console.WriteLine (topCopy.Data);
                topCopy = topCopy.Next;
            }
        }
    }
}
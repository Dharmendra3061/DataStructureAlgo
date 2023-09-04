namespace Stacks {
    using System;

    internal class Node {
        public string Data { get; set; }
        public Node? Next { get; set; }
    }

    internal class Stack {
        public int Size { get; set; }
        public Node? Top { get; set; }

        public void Push (string data) {
            var newNode = new Node ();
            newNode.Data = data;
            newNode.Next = this.Top;

            this.Top = newNode;
        }

        public string Pop () {
            if (this.Top == null) {
                return "Stack is Empty!!!";
            } else {
                string data = this.Top.Data;
                this.Top = this.Top.Next;
                return data;
            }
        }

        public string Peek () {
            if (this.Top == null) {
                return "Stack is Empty!!!";
            } else {
                return this.Top.Data;
            }
        }
    }

    public class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Stack implementation");

            Stack stack = new Stack ();
            
            stack.Push ("A");
            stack.Push ("B");
            stack.Push ("C");

            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
        }
    }
}
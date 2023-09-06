namespace Queues {
    using System;

    internal class Node {
        public string Data { get; set; }
        public Node? Next { get; set; }
    }

    internal class Queue {
        public Node? Front { get; set; }
        public Node? Rear { get; set; }

        public void Enqueue (string data) {
            var newNode = new Node ();
            newNode.Data = data;

            if(this.Rear  == null){
                this.Front = newNode;
                this.Rear = newNode;
            }
            else{
                this.Rear.Next = newNode;
                newNode.Next = null;
                this.Rear = newNode;
            }
        }

        public string Dequeue () {
            string data = string.Empty;
            if (this.Front == null) {
                return "Queue is Empty!!!";
            } else if(this.Front.Next != null){
                data = this.Front.Data;
                this.Front = this.Front.Next;
                return data;
            } else{
                data = this.Front.Data;
                this.Front = null;
                this.Rear = null;
                return data;
            }
        }

        public string Peek () {
            if (this.Front == null) {
                return "Queue is Empty!!!";
            } else {
                return this.Front.Data;
            }
        }

        public void Display(){
            Node temp = this.Front;
            if(this.Front == null){
                Console.WriteLine("Queue is Empty!!!");
            }
            else {
                Console.WriteLine("Queue printing : ");
                while(temp != null){
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }
        }
    }

    public class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Queue implementation");

            Queue queue = new Queue();
            
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Enqueue("D");
            queue.Enqueue("E");

            queue.Display();
            Console.WriteLine(queue.Peek());
            
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            queue.Display();

            queue.Enqueue("F");
            Console.WriteLine(queue.Peek());
            queue.Display();
        }
    }
}
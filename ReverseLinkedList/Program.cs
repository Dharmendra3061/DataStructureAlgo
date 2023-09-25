namespace ReverseLinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
        }        
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Linked List");
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            n1.Next = n2;
            Node n3 = new Node(3);
            n2.Next = n3;
            Node n4 = new Node(4);
            n3.Next = n4;

            Display(n1);
            Reverse(ref n1);
            Display(n1);
        }

        static void Reverse(ref Node head)
        {
            Node current = head;
            Node prev = null;
            Node next = null;
            while(current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head=prev;
        }

        static void Display(Node head)
        {
            Node temp = head;
            Console.WriteLine("Printing Linked list : ");
            while(temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
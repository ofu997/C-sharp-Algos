using System;

namespace Learning_C_sharp_Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new SinglyLinkedList();
            myList.displayList();
            myList.insertFirst(100);
            myList.insertFirst(50);
            myList.insertFirst(99);
            myList.insertFirst(88);
            myList.displayList();
            myList.insertLast(999000);
            myList.insertLast(41);

            myList.deleteFirst();
            myList.displayList(); 
        }

        public class SinglyLinkedList
        {
            public Node first;
            public bool isEmpty()
            {
                return (first == null);
            }

            public void insertFirst(int data)
            {
                Node newNode = new Node();
                newNode.data = data;
                newNode.next = first; 
                first = newNode;
                // Console.WriteLine("{0} {1}", newNode.data, newNode.next);
            }

            public void insertLast(int data)
            {
                {
                    Node current = first;
                    while (current.next != null)
                    {
                        current = current.next;
                    }

                    Node newNode = new Node();
                    newNode.data = data;
                    current.next = newNode; 
                }
            }

            public Node deleteFirst()
            {
                //Node temp = first;
                //first = first.next;
                //return temp;

                first = first.next;
                return first;
            }

            public void displayList()
            {
                Console.WriteLine("List (first -- last");
                Node current = first;
                while (current != null)
                {
                    current.displayNode();
                    current = current.next;
                }
                Console.WriteLine();
            }


        } // SinglyLinkedList

        public class Node
        {
            public int data;
            public Node next;

            public void displayNode()
            {
                Console.WriteLine("<" + data + ">");
            }
        }

        // insertFirst() demo
        // first
        //  99
        //  first
        //      50
        //      first
        //          100
        //          first (a property of var myList)
        //              -__
        //              -__
    }
}

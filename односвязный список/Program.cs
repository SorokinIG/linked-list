using System;
using System.Collections.Generic;


 public  class LinkedList
    {
    int Count;

    Node head;

            class Node

            {

                public Node NextNode; // ссылка на следующий узел

            }
    public void push()
    {
       
        Node new_node = new Node();  

        new_node.NextNode = head;  

        head = new_node;  
    }

    Node FindCicleNode(Node node)
        {
        Count = 0;
            Node slow = node, fast = node;
            while(slow!=null && fast !=null && fast.NextNode != null)
            {
            Count++;
                slow = slow.NextNode;
                fast = fast.NextNode.NextNode;
                if (slow == fast)
                {
                Console.WriteLine(Count);
                
                return slow;

                }
            }
            return null;
        }


        static void Main(string[] args)
        {

        LinkedList llist = new LinkedList();

        llist.push();  //1
        llist.push();  //2
        llist.push();  //3
        
        llist.head.NextNode.NextNode.NextNode = llist.head;

        llist.FindCicleNode(llist.head.NextNode.NextNode.NextNode);

        Console.ReadKey();
        }

        /*
          Node FindCicleNode(Node node)  

        {
            Node head = node;                                                        

            Node current = head;

            LinkedList<Node> n = new LinkedList<Node>();  //создадим пустой список


            do
            {
                n.AddLast(current);  //добавить текущий узел

                foreach (var res in n)
                {

                    if (res.Equals(current.NextNode))      //если следующий узел равен уже какому либо из добавленных, то вывести
                    {
                        return current.NextNode;
                    }

                }

                current = current.NextNode;

            } while (current != head);

            return current;  
        }

        */

    }


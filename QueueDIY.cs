using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_3
{
    public class QueueDIY
    {
        public class Node
        {
            public Node prev, next;
            public Customers data;
        }


        public Node rear, front;

        public bool IsEmpty()
        {
            return rear == null || front == null;
        }

        public void Enqueue(Customers customers)
        {
            Node node = new Node();
            node.data = customers;
            if (rear == null)
            {
                rear = node;
                front = node;
            }
            else
            {
                node.next = rear;
                rear = node;
            }
        }

        public Node Dequeue()
        {
            if (front == null)
                return null;
            Node node = front;
            front = front.prev;
            return node;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructure_Binary
{
    public class LinkedListQueue<T>
    {
        public Node<T> head;
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public int Size()
        {
            Node<T> temp = this.head;
            int count = 0;
                if (temp == null)
            {
                Console.WriteLine("Linked List Queue is empty");
                return -1;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
                count++;
            }
            return count;
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("stack is empty,Deletion is not possible");
                return;
            }
            else
            {
                Console.WriteLine("value popped is {0}", this.head.data);
                this.head = this.head.next;
            }
        }
    }

}

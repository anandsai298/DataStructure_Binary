using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructure_Binary
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
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
            Console.WriteLine("{0} inserted into LinkedList", node.data);
        }
        public void AddReverseOrder(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newnode;
                head.next = temp;
            }
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void InsertParticularPosition(int position, T data)
        {
            Node<T> newstnode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newstnode;
            }
            if (position == 0)
            {
                newstnode.next = this.head;
                this.head = newstnode;
                return;
            }
            Node<T> prev = null;
            Node<T> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newstnode.next = prev.next;
            prev.next = newstnode;
        }
        public void RemoveFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            this.head = this.head.next;
        }
        public void RemoveLastNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            if (head.next == null)
            {
                this.head = null;
            }
            Node<T> NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
        }
        public int Search(T value)
        {
            Node<T> node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals( value))
                {
                    Console.WriteLine(count);
                    return count;
                }
                node = node.next;
                count++;
            }
            return -1;
        }
        public void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            Node<T> temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node<T> next = temp.next.next;
            temp.next = next;
            Size();
        }
        public void Size()
        {
            Node<T> temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length of LinkedList is :" + count);
        }
    }
}

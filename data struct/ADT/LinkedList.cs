using System;
using System.Collections.Generic;
using System.Text;

namespace data_struct.ADT
{
    public class LinkedList<AnyType>
    {
        Node<AnyType> head = null;
        Node<AnyType> tail = null;

        public void AddLast(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>();
            newItem.data = data;

            if (head == null)
            {
                //First item
                //head --> newItem
                //tail --> newItem
                tail = head = newItem;
            } else
            {
                // Not a First item
                // tail = newItem
                tail.next = newItem;
                tail = newItem;
            }
        }

        public void AddFirst(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>();
            newItem.data = data;

            if (head == null)
            {
                head = newItem;
                head.next = null;
            } else
            {
                newItem.next = head;
                head = newItem;
            }
        }

        public void ReadAll()
        {

            Node<AnyType> current = head;

            while (current.next != null)
            {
                Console.WriteLine(current.data);

                current = current.next;

            }

            Console.WriteLine(current.data);
        }
    }
}

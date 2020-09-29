using System;
namespace dot_net_tdd
{
    public class DeLayneList
    {
        Node head;
        Node tail;

        public int Size { get; private set; }

        public void Add(object obj)
        {
            Node node = new Node();
            node.data = obj;

            if (head == null)
            {
                head = node;
                tail = node;
            } else
            {
                tail.next = node;
                tail = node;
            }

            Size++;
        }

        public void Remove(int index)
        {
            if (Size <= 0 || index < 0 || Size <= index)
            {
                throw new ArgumentOutOfRangeException();
            }
            Size--;
        }

        public void Insert(int index)
        {
            Size++;
        }

        public object Get(int index)
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                if (count == index)
                {
                    return current.data;
                }
                current = current.next;
                count++;
            }

            throw new ArgumentOutOfRangeException();
        }

        class Node
        {
            public Object data;
            public Node next;
        }
    }
}

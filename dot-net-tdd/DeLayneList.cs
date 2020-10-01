using System;
using System.Collections.Generic;

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
            }
            else
            {
                tail.next = node;
                tail = node;
            }

            Size++;
        }

        public object Remove(int index)
        {
            if (Size <= 0 || index < 0 || Size <= index)
            {
                throw new ArgumentOutOfRangeException();
            }
            Size--;

            // 0       1      2
            //[3] -> [34] -> [c]
            // remove 0

            // [3] < -- orphaned in memory (GC picks up)
            // [34] -> [c]
            //  H

            // 0       1      2
            //[3] -> [34] -> [c]
            // remove 1

            // 0       1
            //[3] -> [c]

            //take one before and point to one after
            //retrive data

            if (index == 0)
            {
                object temp = head.data;
                head = head.next;
                return temp;
            }
             
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            object result = current.next.data;
            current.next = current.next.next;
            if (current.next == null)
            {
                tail = current;
            }
            return result;


            /*
                        Node previous = null;
                        Node current = head;

                        for (int i = 0; i <= index; i++)
                        {
                            previous = current;
                            current = current.next;
                        }
                        object result = current.data;
                        current = current.next;
                        if (index == 0)
                        {
                            head = current;
                        } else if (current.next == null)
                        {
                            tail = current;
                        }
                        return result;*/


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

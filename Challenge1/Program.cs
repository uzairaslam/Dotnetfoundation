using System;
using System.Linq;

namespace Challenge1
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    class Program
    {
        private static Node head = null;
        public static void Insert(int value, int location)
        {
            Node p = new Node(value);
            if (location == 1)
                head = p;
            else
            {
                Node current = head;
                for (int i = 0; i < location; i++)
                {
                    if (location == i + 2)
                    {
                        if (current.next != null)
                            p.next = current.next;
                        current.next = p;
                        break;
                    }
                    else
                    {
                        current = current.next;
                    }
                }
            }
        }
        public static void display()
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(string[] args)
        {

            string sampleInput = "1 5 10 3 6";
            int[] sampleArr = sampleInput.Trim().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < sampleArr.Length; i++)
            {
                Insert(sampleArr[i], i + 1);
            }

            Insert(9, 3);

            display();
            Console.ReadLine();
        }
    }
}

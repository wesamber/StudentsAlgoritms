using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfStudents
{
    public class SingleLinkedList : ILinkedList
    {
        public Node? Head { get; set; }
        private int cnt;
        public int Count { get => cnt; }

        public SingleLinkedList() { }

        // باللائحة الخطية العادية حيكون  ال prev ديما null لهيك حنفترض انو مالو موجود 
        public void AddFirst(Student std)
        {
            Node newNode = new Node(std);
            newNode.Next = Head;
            Head = newNode;
            cnt++;
        }

        public void AddLast(Student std)
        {
            Node newNode = new Node(std);
            if (Head == null)
            {
                Head = newNode;
                cnt++;
                return;
            }
            Node Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
            cnt++;
        }

        public void DeleteByNumber(int number)
        {
            if (Head == null)
                return;

            if (Head.Data.StudentNumber == number)
            {
                Head = Head.Next;
                cnt--;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data.StudentNumber == number)
                {
                    current.Next = current.Next.Next;
                    cnt--;
                    return;
                }
                current = current.Next;
            }
        }


        public void Print()
        {
            if (Head == null)
            {
                Console.WriteLine("Must input a student.");
                return;
            }

            Node current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Data.ToString());
                current = current.Next;
            }
        }

    }
}

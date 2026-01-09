using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DataOfStudents
{
    public class DoubleLinkedList
    {
        public Node? Head {  get; set; }
        private int cnt = 0; // مشان اعرف كم طالب عندي 
        public int Count { get => cnt; }

        public DoubleLinkedList() { }

        public void AddFirst(Student std)
        {
            Node newNode = new Node(std);
            if (Head != null)
            {

                newNode.Next = Head;
                Head.Prev = newNode;
            }
            Head = newNode; // هي الخطوة بكل الاحوال اذا كانت السلسلة او لا 
            cnt++;
        }

        public void AddLast(Student std)
        {
            Node newNode = new Node(std);
            if (Head == null )
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
            newNode.Prev = Current;
            Current.Next = newNode;
            cnt++;
        }
    }
}

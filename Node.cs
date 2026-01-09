using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfStudents
{
    public class Node
    {
        public Student Data { get; set; }
        public Node? Next { get; set; } // مؤشر لل node التالية
        public Node? Prev { get; set; } // مؤشر لل node السابقة

        public Node (Student std) 
        {
            Data = std;
            Next = null;
            Prev = null;
        }

    }
}

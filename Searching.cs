using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfStudents
{
    public static class Searching<T> where T : ILinkedList
    {
        // فعل جينيريك للبحث عن علامة ضمن لائحة
        public static List<Student>? SearchByMark(double mark, Node? current)
        {
            List<Student>? result = new List<Student>();

            if (current == null)
                return result;

            if (current.Data.MarkQuiz1 == mark || current.Data.MarkQuiz2 == mark)
            {
                // لا يهم اذا كانت العلامة هي الاولى ام الثانية
                result.Add(current.Data);
            }

            result.AddRange(SearchByMark(mark, current.Next));

            return result;

        }

        // ارجاع الطلاب الذين حاصلين على اكثر من علامة معينة
        // الطلاب الذين محصلتهم اكثر من 85 ولكن التخصيص عندد الاستدعاء بال main 
        public static List<Student> StudentMoreTheMark(double outcome, Node? current)
        {
            var result = new List<Student>();
            if (current == null)
                return result;

            if (current.Data.Outcome > outcome)
                result.Add(current.Data);

            result.AddRange(StudentMoreTheMark(outcome, current.Next));
            return result;
        }

    }
}

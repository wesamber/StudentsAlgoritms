using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfStudents
{
    public class Student
    {
        public int StudentNumber { get; set; }
        public string? FullName { get; set; }
        public string? Governorate { get; set; }
        public double MarkQuiz1 { get; set; }
        public double MarkQuiz2 { get; set; }
        public double Outcome { get => (MarkQuiz1 + MarkQuiz2) / 2; }
        public Estimate Estimate { get; set; }

        public Student() { }
        public Student(int num, string name, string gov,double mark1, double mark2, Estimate estimate)
        {
            StudentNumber = num;
            FullName = name;
            Governorate = gov;
            MarkQuiz1 = mark1;
            MarkQuiz2 = mark2;
            Estimate = estimate;
        }

        public override string ToString()
        {
            // استخدمت ال strringbuilder لانو اسرع بعمليات الاضافة عالنص 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"====== Student Info =====");
            sb.AppendLine($"Number of student: {StudentNumber}");
            sb.AppendLine($"Full Name : {FullName}");
            sb.AppendLine($"Governorate : {Governorate}");
            sb.AppendLine($"Mark in Quiz 1 : {MarkQuiz1}");
            sb.AppendLine($"Mark in Quiz 2 : {MarkQuiz2}");
            sb.AppendLine($"Outcome of Student : {Outcome}");
            sb.AppendLine($"The Estimate : {Estimate}");
            sb.AppendLine("===============");

            return sb.ToString();
        }

        
    }
}

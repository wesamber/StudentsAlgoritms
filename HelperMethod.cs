using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfStudents
{
    // كلاس ححط فيه الافعال يلي ممكن تساعدني بالحل مشان ما كررها بكل الاماكن
    public static class HelperMethod
    {
        // فعل لتحويل الاسم الى احرف صغيرة مشان المقارنة تكون بغض النظر عن حالة الاحرف كبيرة او صفيرة
        public static string ToLower(string s)
        {
            string sLower = "";
            foreach (char c in s)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    sLower += (char)(c + 32);
                }
                else
                {
                    sLower += c;
                }
            }
            return sLower;
        }

        // فعل حتى اتحقق من نوع التقدير يلي دخلو المستخدم للطالب 
        public static Estimate? ChooseEstimate(string s)
        {
            s = ToLower(s);
            switch (s)
            {
                case "failed":
                    return Estimate.Failed;

                case "good":
                    return Estimate.Good;

                case "verygood":
                    return Estimate.VeryGood;

                case "excellent":
                    return Estimate.Excellent;
                
                    default :
                return null;
            }

        }

        public static int CompareStrings(string s1, string s2)
        {
            int minLength = s1.Length;

            // بس اذا كان اسم الطالب الاول اصغر من اسم الطالب التاني بيختلف
            // اما اذا كانو متساوين فما بتفرق
            if(s2.Length < s1.Length)
                minLength = s2.Length;

            // الميثود يلي عملناها للاحرف
            s1 = ToLower(s1);
            s2 = ToLower(s2);

            for (int i = 0; i < minLength; i++)
            {
                if (s1[i] < s2[i])
                    return -1; 
                if (s1[i] > s2[i])
                    return 1;  
            }

            // إذا كل الأحرف متساوية وقتا منقارن الفرق بالطول
            if (s1.Length < s2.Length)
                return -1;
            else if (s1.Length > s2.Length)
                return 1;
            else
                return 0; // متساويتين
        }

    }
}

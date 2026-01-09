using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfStudents
{
        // مشان عمم افعال الفرز عنوعين اللوائح ساويتو جينيريك 
        // وضفت انترفيس خليت فيه مؤشر ثابت 
        // في حال انبعت للافعال نوع معطيات غير الللوائح ما يرمي اكسبشن 
        // لانو ما حيقبل ياخد شي غير نوعين اللوائح يلي عاملن
    public static class Sorting<T> where T : ILinkedList
    {
        // كونو القائمة من نوع مرجع فالتعديل عالمكان الاصلي 
        //يعني مافي داعي ارجع ابعت اللائحة بعد الفرز 
        public static void BubbleSortByOutcome(T list)
        {
            if (list.Head == null)
                return;

            bool flag;
            do
            {
                flag = false;
                Node? current = list.Head;

                while (current != null && current.Next != null)
                {
                    if (current.Data.Outcome > current.Next.Data.Outcome)
                    {
                        //  تبادل البيانات فقط الحلقات ثابتة
                        var temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;

                        flag = true;
                    }
                    current = current.Next;
                }
            } while (flag); // طالما صار تعديل معناها لسا ما خلصت السلسلة
        }

        // reference type كمان نفس الفكرة من نوع 
        public static void BubbleSortByFullName(T list)
        {
            if(list.Head == null)
                return;

            bool flag;
            do
            {
                flag = false;
                Node? current = list.Head;
                while(current != null && current.Next != null)
                {
                    if(HelperMethod.CompareStrings(current.Data.FullName , current.Next.Data.FullName) == -1)
                    {
                        // بس اذا كان الاول اصغر بدل والا لا تبدل شي
                        var temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;

                        flag = true;
                    }
                    current = current.Next;
                }
            }while (flag);
        }

    }
}

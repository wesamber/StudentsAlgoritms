using System.Collections.Specialized;
using DataOfStudents;

public class Program
{
    public static void Main(string[] args)
    {
        SingleLinkedList singleLinkedList = new SingleLinkedList();
        int num;
        do
        {
            Console.WriteLine("Welcom to your application");
            Console.WriteLine("================ \n"
                + "Input the number: \n"
                + " 1: Print All Student. \n"
                + " 2: Add the Student. \n"
                + " 3: The Sorting of Students. \n"
                + " 4: Search of Student by mark.\n"
                + " 5: Print the student of Outcome more than 85.\n"
                + " 6: Delete a student.\n"
                + " 7: Exit."
                );
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    singleLinkedList.Print();
                    break;

                case 2:
                    Console.Write("Enter Number of student:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Full Name:");
                    string name = Console.ReadLine();
                    Console.Write("Enter Governorate:");
                    string governor = Console.ReadLine();
                    Console.Write("MarkQuiz1 :");
                    double mark1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("MarkQuiz2 :");
                    double mark2 = Convert.ToDouble(Console.ReadLine());

                    Estimate estimate = Estimate.Failed; // قيمة افتراضية
                    bool flage = false;
                    while (!flage)
                    {
                        Console.Write("Estimate (Failed - Good - VeryGood - Excellent): ");
                        string s = HelperMethod.ToLower(Console.ReadLine());
                        switch (s)
                        {
                            case "failed":
                                estimate = Estimate.Failed;
                                flage = true;
                                break;

                            case "good":
                                estimate = Estimate.Good;
                                flage = true;
                                break;

                            case "verygood":
                                estimate = Estimate.VeryGood;
                                flage = true;
                                break;

                            case "excellent":
                                estimate = Estimate.Excellent;
                                flage = true;
                                break;

                            default:
                                Console.WriteLine("Input Error, try again...");
                                break;
                        }
                    }

                    Student std = new Student(number, name, governor, mark1, mark2, estimate);
                    singleLinkedList.AddLast(std); // ضيف الطالب للقائمة
                    break;

                case 3:
                    Console.WriteLine("Choose type the sorting \n"
                     + "1: Sotoing by Name of Student 'A' to 'Z'. \n "
                     + "2: sortin by Outcome of Stident ASC.");
                    int n = Convert.ToInt32(Console.ReadLine());
                    bool flag = false;
                    while (!flag)
                    {
                        switch (n)
                        {
                            case 1:
                                Console.WriteLine("The Studets befor the sorting:");
                                singleLinkedList.Print();
                                Sorting<SingleLinkedList>.BubbleSortByFullName(singleLinkedList);
                                Console.WriteLine("The Students After Sorting:");
                                singleLinkedList.Print();
                                flag = true;
                                break;

                            case 2:
                                Console.WriteLine("The Studets befor the sorting:");
                                singleLinkedList.Print();
                                Sorting<SingleLinkedList>.BubbleSortByOutcome(singleLinkedList);
                                Console.WriteLine("The Students After Sorting:");
                                singleLinkedList.Print();
                                flag = true;
                                break;

                            default:
                                Console.WriteLine("Error Input , Try Again...");
                                break;
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("Enter the mark the you need search by that: ");
                    double mark = Convert.ToDouble(Console.ReadLine());
                    List<Student>? students = Searching<SingleLinkedList>.SearchByMark(mark, singleLinkedList.Head);
                    if (students == null || students.Count == 0)
                    {
                        Console.WriteLine("Not Found The Student has this mark" + mark);
                        break;
                    }
                    foreach (var student in students)
                    {
                        Console.WriteLine(student);
                    }
                    break;

                case 5:
                    List<Student>? stds = Searching<SingleLinkedList>.StudentMoreTheMark(85, singleLinkedList.Head);
                    if (stds == null || stds.Count == 0)
                    {
                        Console.WriteLine("Not Found The Student grather than 85.");
                        break;
                    }
                    foreach (var student in stds)
                    {
                        Console.WriteLine(student);
                    }
                    break;

                case 6:
                    Console.Write("Enter The number of student that you delete it:");
                    int numb = Convert.ToInt32(Console.ReadLine());
                    singleLinkedList.DeleteByNumber(numb);
                    Console.WriteLine("The Deleted is successful.");
                    break;

                case 7:
                    break;
            }
        } while (num != 7);
    }
}
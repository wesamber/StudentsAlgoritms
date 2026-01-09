using DataOfStudents;

public class Program
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.WriteLine("Welcom to your application");
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            Console.WriteLine("================ \n"
                + "Input the number: \n"
                + " 1: Print All Student. \n"
                + " 2: Add the Student. \n"
                + " 3: The Sorting of Students. \n"
                + " 4: Search of Student by mark.\n"
                + " 5: Print the student of Outcome more than 85.\n"
                + " 6: Delete a student.\n"
                );
            switch (num)
            {
                case 1:
                    singleLinkedList.Print(); 
                    break;

                    //case 2:
                    //Console.Write("Enter Number of student:");
                    //int number = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("Enter Full Name:");
                    //string name = Console.ReadLine();
                    //Console.Write("Enter Governorate:");
                    //string governor = Console.ReadLine();
                    //Console.Write("MarkQuiz1");
                    //double mark1 = Convert.ToDouble(Console.ReadLine());
                    //Console.Write("MarkQuiz2");
                    //double mark2 = Convert.ToDouble(Console.ReadLine());
                    //Console.Write("Estimate (Failed - Good - VeryGood - Excellent)");
                    //string s = Console.ReadLine();
                    //while (HelperMethod.ChooseEstimate(s) == null)
                    //{
                    //    Console.WriteLine("Input Error");
                    //    s = Console.ReadLine();
                    //}
                    //Estimate estimate = HelperMethod.ChooseEstimate(s);

            }
        } while(num > 6 && num <1);
    }
}
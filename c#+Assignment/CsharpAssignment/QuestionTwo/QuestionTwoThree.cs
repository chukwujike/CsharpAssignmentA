using System;


namespace CsharpAssignment.QuestionTwo
{
    public class QuestionTwoThree
    {
        public static void QuestionTwoThreeExe()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"{number}! = {factorial}");

        }
    }
}
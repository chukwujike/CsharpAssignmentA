using System;

namespace CsharpAssignment.QuestionOne
{
    class assignmentOneTwo
    {
        public static void assignmentOneTwoExe()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            double max = Math.Max(num1, num2);
            Console.WriteLine($"The maximum of the two numbers is: {max}");
        }

    }
}
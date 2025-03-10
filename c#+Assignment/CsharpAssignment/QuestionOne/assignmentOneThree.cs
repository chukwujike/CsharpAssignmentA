using System;

namespace CsharpAssignment.QuestionOne
{
    class assignmentOneThree
    {
        public static void assignmentOneThreeExe()
        {
            Console.Write("Enter the width of the image: ");
            int width = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the height of the image: ");
            int height = Convert.ToInt32(Console.ReadLine());


            if (width > height)
                Console.WriteLine("The image is in landscape mode.");
            else if (height > width)
                Console.WriteLine("The image is in portrait mode.");
            else
                Console.WriteLine("The image is square.");
        }

    }
}
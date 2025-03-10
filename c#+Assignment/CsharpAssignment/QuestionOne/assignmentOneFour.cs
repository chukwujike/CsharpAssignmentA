using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment.QuestionOne
{
    public class assignmentOneFour
    {
        public static void assignmentOneFourExe()
        {
            Console.Write("Enter the speed limit: ");

            // Reads the speed limit input and converts it to an integer.
            int speedLimit = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the speed of the car: ");

            // Reads the car's speed input and converts it to an integer.
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            // Checks if the car's speed is within the speed limit.
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                // Calculates demerit points based on the speed difference.
                int demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine($"Demerit Points: {demeritPoints}");

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment.QuestionThree
{
    public class QuestionThreeTwo
    {
        public static void QuestionThreeTwoExe()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reversedName = new string(nameArray);

            Console.WriteLine($"Reversed name: {reversedName}");

        }
    }
}
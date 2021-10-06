using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_6___loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ////prompter
            //int min;
            //int max;
            //int input;

            //Console.WriteLine("enter a minimum number");
            //min = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter a maximum number");
            //max = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("now enter a number between the two");
            //input = Convert.ToInt32(Console.ReadLine());

            //while ((input <= min) || (input >= max))
            //{
            //    Console.WriteLine("enter a number between the two");
            //    input = Convert.ToInt32(Console.ReadLine());
            //}

            //if ((input > min) && (input < max))
            //{
            //    Console.WriteLine("you entered " + input + " which is in between " + min + " and " + max);
            //}

            ////PercentPassing

            //bool done = false;
            //int totalPass = 0, percent;
            //Console.WriteLine("enter the grade percentages and follow instructions to end the program");
            //while (done != true)
            //{
            //    percent = Convert.ToInt32(Console.ReadLine());
            //    if (percent > 50)
            //    {
            //        totalPass = totalPass + 1;
            //    }

            //    Console.WriteLine("do you want to continue? Y or N");
            //    string answer = Console.ReadLine().ToUpper();
            //    if (answer == "N")
            //    {
            //        done = true;
            //    }
            //}

            //Console.WriteLine($"the number of passing grades are {totalPass}");

            //oddSum

            int userInput;

            Console.WriteLine("enter a number to get the odd numbers in it");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < userInput; i = i + 2)
            {
                Console.WriteLine(Convert.ToString(i));
            }





            Console.ReadLine();
        }
    }
}

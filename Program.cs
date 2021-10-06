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
            //prompter
            int min;
            int max;
            int input;

            Console.WriteLine("enter a minimum number");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a maximum number");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("now enter a number between the two");
            input = Convert.ToInt32(Console.ReadLine());

            while ((input <= min) || (input >= max))
            {
                Console.WriteLine("enter a number between the two");
                input = Convert.ToInt32(Console.ReadLine());
            }

            if ((input > min) && (input < max))
            {
                Console.WriteLine("you entered " + input + " which is in between " + min + " and " + max);
            }

            Console.WriteLine();

            //PercentPassing

            bool done = false;
            int totalPass = 0, percent;
            double average;
            percent = 0;
            int totalTests = 0;
            Console.WriteLine("enter the grade percentages and follow instructions to end the program");
            while (done != true)
            {
                percent = Convert.ToInt32(Console.ReadLine());
                if (percent >= 70)
                {
                    totalPass = totalPass + 1;
                }



                Console.WriteLine("do you want to continue? Y or N");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "N")
                {
                    done = true;
                }

                totalTests = totalTests + 1;
            }

            average = (((double)totalPass / totalTests) * 100);

            Console.WriteLine($"the percent of passes is {average}%");

            Console.WriteLine();

            //oddSum

            int userInput;

            Console.WriteLine("enter a number to get the odd numbers in it");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < userInput; i = i + 2)
            {
                Console.WriteLine(Convert.ToString(i));
            }

            Console.WriteLine();

            //randomNumbers

            int[] numbers = new int[25];
            Random rnd = new Random();
            


            Console.WriteLine("enter a minimum number");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a maximum number");
            max = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(min, max);
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("press anything to close");


            Console.ReadLine();
        }
    }
}

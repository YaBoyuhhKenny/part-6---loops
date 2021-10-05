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

            if((input > min) && (input < max))
            {
                Console.WriteLine("you entered " + input + " which is in between " + min + " and " + max);
            }

            Console.ReadLine();
        }
    }
}

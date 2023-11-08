using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number is negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }

                string evenOrOdd = (number % 2 == 0) ? "even" : "odd";
                Console.WriteLine("The number is " + evenOrOdd + ".");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ReadKey();
        }
    }
}

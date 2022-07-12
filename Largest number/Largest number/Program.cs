using System;

namespace Largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of nums

            int num1, num2, num3;
            Console.Write("\n\n");//to skip ines
            Console.Write("Find the largest number in 3 numbers");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The first number is the largest");
                }
                else
                {
                    Console.WriteLine("The third number is the largest");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The second number is the largest");
            }
            else 
            {
                Console.WriteLine("The third number is the largest amongst the 3");
            }
            }

        }
    }


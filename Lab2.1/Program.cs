using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Grand Circus' Room Detail Genereator!");
            char doAgain;
            bool runP = true;
            while (runP == true)


            {
                Console.WriteLine("Please enter the length of your room (in decimal form) :");
                string input1 = Console.ReadLine();
                double.TryParse(input1, out double length);
                while (!double.TryParse(input1, out length))
                {
                    Console.WriteLine("Sorry, that was not a valid response, please re-enter the length of your room (in decimal form) ");
                    input1 = Console.ReadLine();
                    double.TryParse(input1, out length);
                }


                Console.WriteLine("Please enter the width of your room (in decimal form) :");
                string input2 = Console.ReadLine();
                double.TryParse(input2, out double width);
                while (!double.TryParse(input2, out width))

                {
                    Console.WriteLine("Sorry, that was not a valid response, please re-enter amount (in decimal form)");
                    input2 = Console.ReadLine();
                    double.TryParse(input2, out width);
                }

                {
                    double area = (length * width);
                    Console.WriteLine($"Area = {area}");
                    double perimeter = ((length * 2) + (width * 2));
                    Console.WriteLine($"Perimeter = {perimeter}");
                    {
                        Console.WriteLine("Would You Like To Calculate Another Room? (y/n)");

                        doAgain = Convert.ToChar(Console.ReadLine().ToLower());
                        if (doAgain == 'n')
                        {
                            Console.WriteLine("Thank You, Goodbye!");
                            runP = false;
                        }
                        else if (doAgain == 'y')
                        {
                            runP = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid respone, please re-enter your response \n Would You Like To Calculate Another Room? (y/n)");
                            doAgain = Convert.ToChar(Console.ReadLine().ToLower());
                        }
                    }
                }
            }
        }
    }
}

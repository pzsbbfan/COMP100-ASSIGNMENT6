using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT6
{
    internal class Program
    {
        //Display menu method  
        public static void DisplayMenu()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("Calculation Menu            +");
            Console.WriteLine("0) To Exit                  +");
            Console.WriteLine("3) Calculate Sum            +");
            Console.WriteLine("4) Calculate Sum of Squares +");
            Console.WriteLine("5) Calculate Sum of Cubes   +");
            Console.WriteLine("6) Calculate Average        +");
            Console.WriteLine("7) Display Equation         +");
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("Enter the number corresponds to your choice: ");
        }

        public static int CalculateSum(int numberOfInputs)
        {
            int sum = 0;
            //loop over many times depend of user input  
            for (int i = 0; i < numberOfInputs; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter the {i + 1}th number:");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            return sum;
        }

        public static int CalculateSumOfSquares(int numOfSquares)
        {
            int sum = 0;
            for (int i = 0; i < numOfSquares; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter the {i + 1}th number you want to add to sum of squares: ");
                int square = Convert.ToInt32(Console.ReadLine());
                sum += square * square;
            }
            return sum;
        }

        public static int CalculateSumOfCubes()
        {
            int sum = 0;
            Console.WriteLine($"Enter the number of inputs you will be working with: ");
            int inputTimes = Convert.ToInt32(Console.ReadLine());
            for (int time = 0; time < inputTimes; time++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter the {time + 1}th number you wan to add to sum of cubes: ");
                int cube = Convert.ToInt32(Console.ReadLine());
                sum += cube * cube * cube;
            }
            return sum;
        }

        public static double CalculateAverage()
        {
            double average = 0, sum = 0;
            Console.WriteLine("Enter the number of inputs you will be working with");
            int inputTimes = Convert.ToInt32(Console.ReadLine());
            for (int time = 0; time < inputTimes; time++)
            {
                Console.WriteLine($"Enter the {time + 1}th number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            average = sum / inputTimes;
            return average;
        }

        public static void DisplayEquation()
        { 
            double x = 0.0, y = 0.0;
            Console.WriteLine("x\t5\t3x\t-2x^2\ty");
            while (x <= 2.0)
            {
                y = 5 + (3 * x) - (2 * x * x);
                Console.WriteLine($"{x:f2}\t5.0\t{3*x:f1}\t{(-2*x*x):f1}\t{y:f1}");
                x += 0.25;
            }
        }
        

        static void Main(string[] args)
        {
            int userinput = 0;
            //do while loop to excute the program at least once
            do
            {
                DisplayMenu();
                //prompt for user input
                string temp = Console.ReadLine();
                //using int.TryParse to check if user inputs an integer
                if (int.TryParse(temp, out userinput))
                {
                    //after user inputs an integer, using switch to handle different input cases
                    switch (userinput)
                    {
                        case 0:
                            Console.WriteLine("Thank you for using");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                        case 3:
                            CalculateSum(5);
                            break;
                        case 4:
                            Console.WriteLine("Enter number of inputs will constitute the sum of squares");
                            int input = Convert.ToInt32(Console.ReadLine());
                            CalculateSumOfSquares(input);
                            break;
                        case 5:
                            CalculateSumOfCubes();
                            break;
                        case 6:
                            CalculateAverage();
                            break;
                        case 7:
                            DisplayEquation();
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("INVALID INPUT!!! please try again : ");
                            break;
                    }

                }
                //when user inputs something that is not an integer
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("INVALID INPUT!!! please try again: ");
                    Console.WriteLine();
                    //keep the loop going
                    userinput = 1;
                }
                Console.WriteLine("Press any key to continue: ");
                Console.ReadLine();
                Console.Clear();


            } while (userinput != 0);


            Console.ReadLine();
        }


    }
}

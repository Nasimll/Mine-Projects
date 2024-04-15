using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1 Swaping Numbers

            Console.WriteLine("TASK 1:");

            Console.Write("First number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            firstNum = firstNum + secondNum;
            secondNum = firstNum - secondNum;
            firstNum = firstNum - secondNum;

            Console.WriteLine("Swapping Process");
            Console.WriteLine("First number: " + firstNum);
            Console.WriteLine("Second number: " + secondNum);
            Console.WriteLine();


            // TASK 2 Simple ariphmetics:
            Console.WriteLine("TASK 2:");

            int solution1 = 12 + 4 * 2;
            Console.WriteLine("First Solution: " + solution1);

            float solution2 = 14 + 4 * 6 / 11;
            Console.WriteLine("Second Solution: " + solution2);

            float solution3 = 2 + 15 / 6 * 1 - 7 / 2;
            Console.WriteLine("Third Solution: " + solution3);

            float solution4 = 1 + 4 * 3 / 2 - 1;
            Console.WriteLine("Fourth Solution: " + solution4);
            Console.WriteLine();


            // TASK 3 Simplest Calculator functionality :
            Console.WriteLine("TASK 3:");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double subtraction = num1 - num2;
            double multiplication = num2 * num1;
            double division = num2 / num1;

            Console.WriteLine("Addition: " + sum);
            Console.WriteLine("Subtraction: " + subtraction);
            Console.WriteLine("Muliplication: " + multiplication);
            Console.WriteLine("Division: " + division);
            Console.ReadLine();//To run the code without the console closing immediately after execution


            // TASK 4 Multiplication:
            Console.WriteLine("TASK 4:");

            Console.Write("Enter the first number: ");
            double num1_task4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2_task4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double num3_task4 = Convert.ToDouble(Console.ReadLine());

            double multiplication3 = num1_task4 * num2_task4 * num3_task4;

            Console.WriteLine("Output of Multiplication: " + multiplication3);

            Console.ReadLine();//To run the code without the console closing immediately after execution
        }
    }
}

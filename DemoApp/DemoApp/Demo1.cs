﻿using System;

namespace DemoApp
{
    class Demo1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSimple Calculator Program");
                Console.WriteLine("Enter 1 for Addition");
                Console.WriteLine("Enter 2 for Subtraction");
                Console.WriteLine("Enter 3 for Multiplication");
                Console.WriteLine("Enter 4 for Division");
                Console.WriteLine("Enter 0 to Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                Calculator calculator = new Calculator();
                double[] input;

                switch (choice)
                {
                    case 1:
                        input = getNumbers();
                        Console.WriteLine($"Addition is: {calculator.addition(input)}");
                        break;
                    case 2:
                        input = getNumbers();
                        Console.WriteLine($"Subtraction is: { calculator.subtraction(input)}");
                        break;
                    case 3:
                        input = getNumbers();
                        Console.WriteLine($"Multiplication is: {calculator.multiplication(input)}");
                        break;
                    case 4:
                        input = getNumbers();
                        Console.WriteLine($"Division is: {calculator.division(input)}");
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Enter Correct Choice");
                        break;
                }
            }
        }

        static double[] getNumbers()
        {
            Console.WriteLine("Enter Numbers Seperated With a Space");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            double[] output = new double[arr.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Double.Parse(arr[i]);
            }
            return output;
        }
    }

    public class Calculator
    {
        public double addition(double [] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public double subtraction(double[] numbers)
        {
            double sub = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sub -= numbers[i];
            }
            return sub;
        }

        public double multiplication(double[] numbers)
        {
            double mul = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                mul *= numbers[i];
            }
            return mul;
        }

        public double division(double[] numbers)
        {
            double div = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                div /= numbers[i];
            }
            return div;
        }
    }

}

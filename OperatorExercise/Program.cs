﻿using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input First Number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input Second Number:");
            int b = int.Parse(Console.ReadLine());

            Addition(a, b);

            Subtraction(a, b);

            Multiplication(a, b);

            Division(a, b);

            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());

            AreaOfCircle(radius);

        }
        public static void Addition(int a, int b)
        {
            var result = a + b;
            Console.WriteLine($"{a}+{b} is {result}");
        }
        public static void Subtraction(int a, int b)
        {
            var result = a - b;
            Console.WriteLine($"{a}-{b} is {result}");
        }
        public static void Multiplication(int a, int b)
        {
            var result = a * b;
            Console.WriteLine($"{a}*{b} is {result}");
        }
        public static void Division(int a, int b)
        {
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
        }
        public static void AreaOfCircle(double radius)
        {
            var result = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a Circle with radius {radius} is {result}");
        }
    }
}

/*
 * Author:  Jacob Autrey     
 * Course:  COMP003A
 * Purpose: Assignment 2
 */
using System;

namespace COMP003A.Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            string firstName = Console.ReadLine();
            string middleName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            string inputInteger1 = Console.ReadLine();
            string inputInteger2 = Console.ReadLine();
            int integer1 = Convert.ToInt32(inputInteger1);
            int integer2 = Convert.ToInt32(inputInteger2);
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"area = {area}");
            Console.WriteLine($"circumference = {circumference}");

        }
    }
}

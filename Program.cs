/*
Program: Pyramid Height Calculator
Description: A program to calculate the number of floors a pyramid can have based on an user input.
Author: Adrian Sanchez (EC1939656)
Company: Edinburgh College
Version: 1
*/
using System;

namespace Assesment9
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = 0;
            int counter = 1;
            Console.WriteLine("Enter the amount of blocks you would like your pyramid to have:");
            int input = Convert.ToInt32(Console.ReadLine());
            while (counter<= input)
            {
                floor += 1;
                input -= counter;
                counter += 1;
            }
            Console.WriteLine("The height of the pyramid is:" + floor);
        }
    }
}

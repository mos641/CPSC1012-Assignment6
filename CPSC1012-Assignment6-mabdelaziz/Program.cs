// File:    Program.cs
// Purpose: Ask for and display a box from user specification

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_Assignment6_mabdelaziz
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int length;
            char fillChar;
            string prompt = "Please enter a whole number for the length of the box (greater than 0): ";
            
            // ask for and capture length
            length = InputOutput.GetLength(prompt);
            Console.WriteLine();

            // ask for and capture a filling character
            Console.Write("Please enter a character to fill the box with: ");
            fillChar = char.Parse(Console.ReadLine().Trim());
            Console.WriteLine("");

            // display empty box
            Console.WriteLine("Empty Box");
            InputOutput.DisplayBox(length);

            // display filled box
            Console.WriteLine("Filled Box");
            InputOutput.DisplayBox(length, fillChar);

            // keep the console window open
            Console.ReadLine();
        }
    }
}

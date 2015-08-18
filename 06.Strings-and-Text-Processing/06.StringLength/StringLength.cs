﻿/*
 * Problem 6. String length
 * Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20,
 * the rest of the characters should be filled with *.
 * Print the result string into the console.
 */

using System;

class StringLength
{
    static void Main()
    {
        Console.Write("Please enter string: ");
        string text = Console.ReadLine();
        Console.WriteLine(text.PadRight(20, '*'));
    }
}
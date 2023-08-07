using System;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleCsharp.Basics
{
    public class ListPatterns
    {
        public ListPatterns()
        {
            //Discard pattern
            //The discard pattern assumes that you know the length of the sequence and 
            //match one or more elements from the sequence.
            var scores = new int[] { 1, 2, 3, };
            if(scores is [1, 2, 3]) //only in c# 11 == .NET 7
            {
                Console.WriteLine("Matched!");
            }

            //To check if an array has 5 elements regardless of their values,
            //you can use _ variable like this:
            if(scores is [_, _, _]) Console.WriteLine("Matched!");
            if(scores is [_, 2, _]) Console.WriteLine("Matched: _2,_");


            //Range pattern
            //If you don’t know the length of the sequence, you can use the range pattern. 
            //In the range pattern, you can use the two dots..to specify any number of elements.
            //Note that you can use the two dots once in the sequence.
            //Here we match a list starting with 1, followed by any number and followed by zero 
            //or more numbers
            if(scores is [1, _, ..]) Console.WriteLine("Matched: 1,_,..");

            //To make the pattern more flexible, you can use a relational pattern like this:
            if (scores is [>-1, ..]) Console.WriteLine("Matched: relational  pattern!");

            //Var pattern
            //The var pattern allows you to declare a variable and assign it the value of the matched element. 
            //This variable will be available in the same scope where it was declared.
            if(scores is [var first, _, <4]) Console.WriteLine($"Matched: var pattern is like destructuring! {first}");


        }
    }
}

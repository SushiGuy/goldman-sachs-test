/* Problem Name is &&& Longest Uniform Substring &&& PLEASE DO NOT REMOVE THIS LINE. */

/**
 * Instructions to candidate.
 *  1) Run this code in the REPL to observe its behaviour. The
 *     execution entry point is main().
 *  2) Your task is to implement the following method ('LongestUniformSubstring')
 *     
 *       This method should return a Tuple<int, int> that correctly identifies the location of the longest uniform substring within the 
 *       input string. Item1 of the Tuple is the start index and Item2 is the length.
 *       
 *       e.g. for the input: "abbbccda" the longest uniform substring is "bbb" (which starts at index 1 and is 3 characters long).
 *       Therefore the return value would be a `new Tuple<int, int>(1, 3);
 *
 *  3) If time permits, consider adding some additional test cases
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Coderpad
{
    class Solution
    {
        static Tuple<int, int> LongestUniformSubstring(string input)
        {
           return new Tuple<int, int>(-1, 0);
        }

        //Iterate thru string
        
        static Dictionary<string, Tuple<int, int>> testCases = new Dictionary<string, Tuple<int, int>>
        {
            { "", new Tuple<int, int>(-1, 0) },
            { "10000111", new Tuple<int, int>(1, 4) },
            { "aabbbbbCdAA", new Tuple<int, int>(2, 5) }
        };

        static bool DoTestsPass()
        {
            return testCases.ToList().All(kvp => LongestUniformSubstring(kvp.Key).Equals(kvp.Value));
        }

        static void Main(string[] args)
        {
            if(DoTestsPass())
                Console.WriteLine("All tests pass!");
            else
                Console.Error.WriteLine("At least one test failure!");
        }
    }
}

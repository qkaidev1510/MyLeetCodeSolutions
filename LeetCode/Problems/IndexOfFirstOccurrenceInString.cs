using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Problem 28 - O((N-M) * M)
namespace LeetCode.Problems
{
    public class IndexOfFirstOccurrenceInString
    {
        public static int Solve(string haystack, string needle)
        {
            int i = 0; 
            int j = needle.Count() - 1;
            int len1 = haystack.Count(); 
            int len2 = needle.Count(); 


            while(j < len1) {
                bool canReturn = true; 

                for(int k=i; k<=j; k++)
                    if (haystack[k] != needle[k-i]) {
                        canReturn = false; 
                        break; 
                    }
                
                if (canReturn) 
                    return i; 
                
                i++; 
                j++; 
            }

            return -1; 
        }

        public static void Execute()
        {
            string haystack = "sabbutsad";
            string needle = "sad";
            int res = Solve(haystack, needle);
            Console.WriteLine(res); 
        }

    }
}
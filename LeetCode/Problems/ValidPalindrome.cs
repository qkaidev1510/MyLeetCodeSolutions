using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class ValidPalindrome
    {
        public static bool Solve(string s)
        {
            s = s.ToLower();
            int i = 0;
            int j = s.Count() - 1;

            while (i <= j)
            {

                if (!(
                    (s[i] >= 'a' && s[i] <= 'z') || 
                    (s[i] >= '0' && s[i] <= '9')
                ))
                {
                    i++;
                    continue;
                }


                 if (!(
                    (s[j] >= 'a' && s[j] <= 'z') || 
                    (s[j] >= '0' && s[j] <= '9')
                ))
                {
                    j--;
                    continue;
                }

                if (s[i] != s[j])
                {
                    return false;
                }

                i++;
                j--; 
            }

            return true;
        }

        public static void Execute()
        {
            string s = "race a car";
            Console.WriteLine(Solve(s));
        }
    }
}
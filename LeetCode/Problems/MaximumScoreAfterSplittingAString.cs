using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MaximumScoreAfterSplittingAString
    {
        public static int Solve(string s)
        {
            int[] zeroCounter = new int[s.Length + 1];
            int[] oneCounter = new int[s.Length + 1];

            zeroCounter[0] = 0;
            oneCounter[0] = 0;

            for (int i = 0; i < s.Length; i++)
                if (s[i] == '0')
                {
                    zeroCounter[i + 1] = zeroCounter[i] + 1;
                    oneCounter[i + 1] = oneCounter[i];
                }
                else
                {
                    zeroCounter[i + 1] = zeroCounter[i];
                    oneCounter[i + 1] = oneCounter[i] + 1;
                }

            int res = 0;

            for (int i = 2; i <= s.Length; i++)
            {
                int left = zeroCounter[i - 1];
                int right = oneCounter[s.Length] - oneCounter[i - 1];
                res = int.Max(res, left + right); 
            }

            return res;
        }

        public static void Execute()
        {
            string s = "00";
            Console.WriteLine(Solve(s)); 
        }
    }
    
}
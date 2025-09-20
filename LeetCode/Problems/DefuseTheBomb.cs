using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class DefuseTheBomb
    {
        public static int[] Solve(int[] code, int k)
        {
            int[] res = new int[code.Length];

            if (k == 0)
            {
                for (int i = 0; i < code.Length; i++) res.Append(0);
            }
            else
            {
                int[] arr = new int[code.Length * 2];
                int[] prefixSum = new int[code.Length * 2 + 1];
                prefixSum[0] = 0;

                for (int i = 0; i < code.Length; i++)
                {
                    arr[i] = code[i];
                    arr[i + code.Length] = code[i]; 
                }

                for (int i = 0; i < arr.Length; i++) prefixSum[i+1] = prefixSum[i] + arr[i];



                for (int i = 1; i <= code.Length; i++)
                    if (k > 0)
                    {
                        res[i - 1] = prefixSum[i + k] - prefixSum[i];
                    }
                    else
                    {
                        res[i-1] = prefixSum[i + code.Length - 1] - prefixSum[i + code.Length - 1 + k];
                    }
            }

            return res;
        }

        public static void Execute()
        {
            int[] code = [2,4,9,3];
            int k = -2;
            int[] res = Solve(code, k);
            foreach (int num in res)
                Console.WriteLine(num); 
        }
    }
}

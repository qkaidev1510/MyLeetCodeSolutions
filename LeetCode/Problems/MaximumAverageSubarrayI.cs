using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MaximumAverageSubarrayI
    {
        public static double Solve(int[] nums, int k)
        {
            double res = double.MinValue;
            double[] prefixSum = new double[nums.Length + 1];

            prefixSum[0] = 0; 

            for (int i = 0; i < nums.Length; i++)
                prefixSum[i + 1] = prefixSum[i] + nums[i];

            for (int i = k; i <= nums.Length; i++)
            {
                double sum = prefixSum[i] - prefixSum[i - k];
                res = double.Max(res, sum / k); 
            }

            return res;
        }

        public static void Execute()
        {
            int[] nums = [1, 12, -5, -6, 50, 3];
            int k = 4;
            Console.WriteLine(Solve(nums, k)); 
        }
    }
}
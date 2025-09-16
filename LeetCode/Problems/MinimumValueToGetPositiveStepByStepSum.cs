using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MinimumValueToGetPositiveStepByStepSum
    {
        public static int Solve(int[] nums)
        {
            int res = int.MaxValue;

            int sum = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                sum += nums[i];

                if (sum < 0)
                    res = int.Min(res, sum);
            }

            return int.Max(1 - res, 1);

        }

        public static void Execute()
        {
            int[] nums = {1, 2 };
            Console.WriteLine(Solve(nums));
        }
    }
}
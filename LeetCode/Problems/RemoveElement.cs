using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

//Problem 28
namespace LeetCode.Problems
{
    public class RemoveElement
    {
        public static int Solve(int[] nums, int val)
        {
            int i = -1;
            int j = 0;

            while (j < nums.Count())
            {
                if (nums[j] == val)
                {
                    j++;
                    continue;
                }

                nums[i + 1] = nums[j];
                i++;
                j++;
            }

            return i + 1;

        }

        public static void Execute()
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            var result = Solve(nums, val);
            Console.WriteLine(result);
        }
    }
}


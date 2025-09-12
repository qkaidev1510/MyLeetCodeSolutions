using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;
// Problem 26
namespace LeetCode.Problems
{
    public class RemoveDuplicates
    {
        public static int Solve(int[] nums)
        {
            var i = 0;
            var j = 0;

            while (j < nums.Count())
            {
                if (nums[j] == nums[i])
                {
                    j++;
                    continue;
                }

                var swap = nums[i + 1];
                nums[i + 1] = nums[j];
                nums[j] = swap;

                i++;
                j++;
            }

            return i+1;
        }

        public static void Execute()
        {
            int[] nums = {0,0,1,1,1,2,2,3,3,4};
            var result = Solve(nums);
            Console.WriteLine(result);
        }


    }
}




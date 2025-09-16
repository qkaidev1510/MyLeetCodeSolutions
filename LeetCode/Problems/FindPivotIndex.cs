using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class FindPivotIndex
    {
        public static int Solve(int[] nums)
        {
            int[] prefixSum = new int[nums.Count()];
            prefixSum[0] = nums[0];

            for (int i = 1; i < nums.Count(); i++)
                prefixSum[i] = prefixSum[i - 1] + nums[i];

            if (prefixSum[nums.Count() - 1] - prefixSum[0] == 0) return 0;


            for (int i = 1; i < nums.Count() - 1; i++)
            {

                int leftSum = prefixSum[i - 1];
                int rightSum = prefixSum[nums.Count() - 1] - prefixSum[i];

                if (leftSum == rightSum) return i; 
            }

            if (prefixSum[nums.Count() - 2] == 0) return nums.Count() - 1;
            
            return -1; 
        }


        public static void Execute()
        {
            int[] nums = {-1, -1, 1, 1, 0, 0};
            Console.WriteLine(Solve(nums));
        }
        

    }
}
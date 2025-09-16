using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RangeSumQuery
    {
        public int[] prefixSum;
        public RangeSumQuery(int[] nums)
        {
            prefixSum = new int[nums.Count() + 1];
            prefixSum[1] = nums[0];
            prefixSum[0] = 0;

            for (int i = 2; i <= nums.Count(); i++)
                prefixSum[i] = prefixSum[i-1] + nums[i-1];



        }

        public int SumRange(int left, int right)
        {
            return prefixSum[right + 1] - prefixSum[left]; 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MergeSortedArray
    {
        public static void Solve(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m-1;
            int j = n-1;
            int k = nums1.Count() -1;

            while (i >= 0 || j >= 0)
            {

                if (i == -1)
                {
                    nums1[k] = nums2[j];
                    j--;
                    k--;
                    continue;
                }

                if (j == -1)
                {
                    nums1[k] = nums1[i];
                    i--;
                    k--;
                    continue;
                }

                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }

                k--;
            }

            foreach (int num in nums1)
            {
                Console.Write($"{num} ");
            }
        }

        public static void Execute()
        {
            int[] nums1 = {0};
            int m = 0;
            int[] nums2 = {1};
            int n = 1;

            Solve(nums1, m, nums2, n); 
        }
    }
}
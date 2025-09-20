using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LHS
    {
        public static int FindLHS(int[] nums)
        {
            int res = 0;
            int count1 = 1;
            int count2 = 0;
            bool flag = false;

            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (!flag)
                {
                    if (nums[i] == nums[i - 1])
                    {
                        count1++;
                    }
                    else if (nums[i] == nums[i - 1] + 1)
                    {
                        flag = true;
                        count2 = count1 + 1;
                        count1 = 1;
                    }
                    else
                    {
                        count1 = 1;
                        res = int.Max(res, count2);
                    }
                }
                else
                {
                    if (nums[i] == nums[i - 1])
                    {
                        count2++;
                        count1++;
                    }
                    else if (nums[i] == nums[i - 1] + 1)
                    {
                        res = int.Max(res, count2);
                        count2 = count1 + 1;
                        count1 = 1;
                    }
                    else
                    {
                        flag = false;
                        res = int.Max(res, count2);
                        count2 = 0;
                        count1 = 1;
                    }
                }
            }

            if (flag) res = int.Max(res, count2);

            return res; 
        }

        public static void Execute()
        {
            int[] nums = [1,2,3,4];
            Console.WriteLine(FindLHS(nums)); 
        }
        
    }
}
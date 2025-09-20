using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using LeetCode.Util;

namespace LeetCode.Problems
{
    public class ContainsDuplicateII
    {
        class HashTable : HashTableBase
        {
            private readonly int[] _nums;
            private const int _buffer = 1000000000; 

            public HashTable(int Bucket, int[] nums) : base( Bucket)
            {
                _nums = nums;
            }

            protected override int HashFunction(int value)
            {
                return (value + _buffer) % _base;
            }

            public bool Check(int id, int k)
            {
                if (_table[id].Count() > 1)
                {
                    for (int i = 1; i < _table[id].Count(); i++)
                    {
                        int val1 = _table[id][i];
                        int val2 = _table[id][i - 1];
                        if (val1 - val2 <= k && _nums[val1] == _nums[val2]) return true; 
                    }
                }

                return false; 
            }
        }
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var bucket = nums.Length;

            HashTable h = new HashTable(bucket, nums);

            for (int i = 0; i < nums.Length; i++) h.InsertItem(nums[i], i);
            
            for (int i = 0; i < bucket; i++)
            {
                if (h.Check(i, k) == true) return true; 
            }

            return false; 
        }

        public static void Execute()
        {
            int[] nums = [-1000000000,2,3,1000000000];
            int k = 3;
            Console.WriteLine(ContainsNearbyDuplicate(nums, k));
        }
    }
}


